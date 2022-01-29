using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTrainer
{
    public partial class MainForm : Form
    {
        private const string c_gameName = "ac_client";
        private const string c_friendlyName = "Assault Cube";
        private const string c_notFound = "N/A";
        private static readonly byte[] c_FourBytesZero = {0,0,0,0};
        private static bool isGameOn = false;
        private static int s_originalRecoilCommandLength = 5;
        private static byte[] s_originalRecoilCommand = null;

        private string addrOfEntityArrayAsString = null;
        private string AddrOfEntityArrayAsString { get
            {
                if (addrOfEntityArrayAsString == null && m_memoryObj != null) 
                {
                    byte[] addrOfEntityArray = m_memoryObj.ReadBytes($"base+{c_pointToEntityArrayBaseOffset}", 4);
                    addrOfEntityArrayAsString = "";
                    for (int i = 3; i >= 0; --i)
                    {
                        addrOfEntityArrayAsString += addrOfEntityArray[i].ToString("X2");
                    }
                }

                return addrOfEntityArrayAsString;
            }
        }

        //=======================================================================
        //  Offsets
        //  Abrv:
        //  DBS - Delay Between Shots
        //=======================================================================

        private const string c_basePlayerOffset = "17B264";
        private const string c_recoilCommandOffset = "C0DB0";
        private const string c_numberOfEnemiesOffset = "187C18";
        private const string c_pointToEntityArrayBaseOffset = "187C10"; // The entity is array of pointers to the players object with the first entity as a dummy entity.
        private const string c_XEastPositiveCordOffset = "28";
        private const string c_YNorthNegativeCordOffset = "2C";
        private const string c_ZCordOffset = "30";
        private const string c_MouseXOffset = "34";
        private const string c_MouseYOffset = "38";
        private const string c_JumpOffset = "5D";
        private const string c_HealthOffset = "EC";
        private const string c_ShieldOffset = "F0";
        private const string c_IsTwoPistolOffset = "100";
        private const string c_OnePistolAmmoOffset = "108";
        private const string c_MainWeaponAmmoOffset = "11C";
        private const string c_TwoPistolAmmoOffset = "124";
        private const string c_OnePistolStackOffset = "12C";
        private const string c_MainWeaponStackOffset = "140";
        private const string c_GranadesOffset = "144";
        private const string c_TwoPistolStackOffset = "148";
        private const string c_OnePistolDBSOffset = "150";
        private const string c_MainWeaponDBSOffset = "164";
        private const string c_GranadesDBSOffset = "168";
        private const string c_TwoPistolsDBSOffset = "16C";

        //=======================================================================
        public Mem m_memoryObj = new Mem();

        public MainForm()
        {
            InitializeComponent();
        }

        private void GodMod_CheckedChanged(object sender, EventArgs e)
        {
            if (isGameOn)
            {
                if (GodMod.CheckState == CheckState.Checked)
                {
                    m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_HealthOffset}", "int", "907");
                    health.Enabled = false;
                }
                else
                {
                    try
                    {
                        m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_HealthOffset}");
                        health.Enabled = true;
                    }
                    catch(Exception exc){}
                }
            }
        }

        private async void FindGameAsync()
        {
            while (true) 
            {
                if (!m_memoryObj.OpenProcess(c_gameName)) 
                {
                    isGameOn = false;
                    IsProcFound.Text = c_notFound;
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    continue;
                }
                else
                {
                    isGameOn = true;
                    IsProcFound.Text = $"{c_friendlyName} found";
                }
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FindGameAsync();
        }

        private void InfiniteJumps_CheckedChanged(object sender, EventArgs e)
        {
            if (isGameOn && InfiniteJumps.Checked)
            {
                m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_JumpOffset}", "byte", "1");
            }
            else
            {
                try
                {
                    m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_JumpOffset}");
                }
                catch (Exception exc){}
            }
        }

        private void health_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(health.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_HealthOffset}", "int", health.Text);
            }
        }

        private void sheild_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(sheild.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_ShieldOffset}", "int", sheild.Text);
            }
        }

        private void IsTwoPistols_CheckedChanged(object sender, EventArgs e)
        {
            if (isGameOn && IsTwoPistols.Checked)
            {
                m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_IsTwoPistolOffset}", "byte", "1");
            }
            else
            {
                try
                {
                    m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_IsTwoPistolOffset}");
                }
                catch (Exception exc){}
            }
        }

        private void OnePistolAmmo_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(OnePistolAmmo.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_OnePistolAmmoOffset}", "int", OnePistolAmmo.Text);
            }
        }

        private void MainWeaponAmmo_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(MainWeaponAmmo.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_MainWeaponAmmoOffset}", "int", MainWeaponAmmo.Text);
            }
        }

        private void TwoPistolAmmo_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(TwoPistolAmmo.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_TwoPistolAmmoOffset}", "int", TwoPistolAmmo.Text);
            }
        }

        private void OnePistolStack_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(OnePistolStack.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_OnePistolStackOffset}", "int", OnePistolStack.Text);
            }
        }

        private void MainWeaponStack_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(MainWeaponStack.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_MainWeaponStackOffset}", "int", MainWeaponStack.Text);
            }
        }

        private void Granades_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(Granades.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_GranadesOffset}", "int", Granades.Text);
            }
        }

        private void TwoPistolStack_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(TwoPistolStack.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_TwoPistolStackOffset}", "int", TwoPistolStack.Text);
            }
        }

        private void NoReload_CheckedChanged(object sender, EventArgs e)
        {
            if(isGameOn){ 
                if (NoReload.Checked)
                {
                    Add100AndFreezeAmmo();
                }
                else
                {
                    UnFreezeAmmo();
                }
            }
        }

        private void Add100AndFreezeAmmo()
        {
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_OnePistolAmmoOffset}", "int", "100");
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_MainWeaponAmmoOffset}", "int", "100");
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_TwoPistolAmmoOffset}", "int", "100");
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_OnePistolStackOffset}", "int", "100");
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_MainWeaponStackOffset}", "int", "100");
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_GranadesOffset}", "int", "100");
            m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_TwoPistolStackOffset}", "int", "100");
        }

        private void UnFreezeAmmo()
        {
            try
            {
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_OnePistolAmmoOffset}");
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_MainWeaponAmmoOffset}");
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_TwoPistolAmmoOffset}");
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_OnePistolStackOffset}");
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_MainWeaponStackOffset}");
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_GranadesOffset}");
                m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_TwoPistolStackOffset}");
            }
            catch (Exception exc){}
        }

        private void NoRecoil_CheckedChanged(object sender, EventArgs e)
        {
            if (!isGameOn) 
            {
                return;
            }
            try
            {
                if (NoRecoil.Checked)
                {
                    byte[] originalCommand = m_memoryObj.ReadBytes($"base+{c_recoilCommandOffset}", s_originalRecoilCommandLength);
                    if (s_originalRecoilCommand == null)
                    {
                        s_originalRecoilCommand = originalCommand;
                    }
                    m_memoryObj.WriteBytes($"base+{c_recoilCommandOffset}", new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else 
                {
                    if (s_originalRecoilCommand != null) 
                    {
                        m_memoryObj.WriteBytes($"base+{c_recoilCommandOffset}", s_originalRecoilCommand);
                    }
                }
            }
            catch (Exception exc) { }
        }

        private void NoDBS_CheckedChanged(object sender, EventArgs e)
        {
            // No Delay Between Shots
            try
            {
                if (NoDBS.Checked)
                {
                    m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_GranadesDBSOffset}", "int", "0");
                    m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_TwoPistolsDBSOffset}", "int", "0");
                    m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_MainWeaponDBSOffset}", "int", "0");
                    m_memoryObj.FreezeValue($"base+{c_basePlayerOffset},{c_OnePistolDBSOffset}", "int", "0");
                }
                else
                {
                    m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_GranadesDBSOffset}");
                    m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_TwoPistolsDBSOffset}");
                    m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_MainWeaponDBSOffset}");
                    m_memoryObj.UnfreezeValue($"base+{c_basePlayerOffset},{c_OnePistolDBSOffset}");
                }
            }
            catch (Exception exc) { }
        }

        private async void AimBot_CheckedChanged(object sender, EventArgs e)
        {
            Action actionActivateAimBot = ActivateAimBot;
            await Task.Run(actionActivateAimBot);
        }

        private void ActivateAimBot() 
        {
            int numOfEnemies = 0;
            if (!isGameOn)
            {
                return;
            }
            while (AimBot.Checked && isGameOn) 
            {

                do
                {
                    numOfEnemies = m_memoryObj.ReadInt($"base+{c_numberOfEnemiesOffset}") - 1;
                    if (!AimBot.Checked) 
                    {
                        return;
                    }
                }while (numOfEnemies < 1);
                float x = m_memoryObj.ReadFloat($"base+{c_basePlayerOffset},{c_XEastPositiveCordOffset}");
                float y = m_memoryObj.ReadFloat($"base+{c_basePlayerOffset},{c_YNorthNegativeCordOffset}");
                float z = m_memoryObj.ReadFloat($"base+{c_basePlayerOffset},{c_ZCordOffset}");
                List<playerCord> playersCord = initPlayersList(numOfEnemies);
                var myCord = new playerCord() { x = x, y = y, z = z };
                // plus 1 since in the entity array the first item is a dummy.
                int enemyIndexList = Utils.GetClosestPlayer(playersCord, myCord);
                // now I need to aim my crosshair on this enemy location.
                //Trace.WriteLine($"closest enemy is in index: {enemyIndex}");
                //Trace.WriteLine($"closest enemy is in Cord: x={playersCord[enemyIndex].x}, y={playersCord[enemyIndex].y}, z={playersCord[enemyIndex].z}");
                //Trace.WriteLine($"My cords our: x={myCord.x}, y={myCord.y}, z={myCord.z}");

                playerCord enemyUpdatedCords = GetEnemyCords(enemyIndexList+1);
                float MouseX = Utils.ConvertRadiansToFloatDegrees(Math.Asin(Utils.Dist1D(myCord, enemyUpdatedCords) / Utils.Dist2DXY(myCord, enemyUpdatedCords)));
                MouseX = Utils.AdjustMosueXToCorrectRangeAndLocation(myCord, enemyUpdatedCords, MouseX);
                float MouseY = Utils.ConvertRadiansToFloatDegrees(Math.Acos(Utils.Dist2DXY(myCord, enemyUpdatedCords) / Utils.Dist3D(myCord, enemyUpdatedCords)));
                MouseY = Utils.AdjustMosueYToCorrectRangeAndLocation(myCord, enemyUpdatedCords, MouseY);
                //Trace.WriteLine($"MouseX angle is: {MouseX}");
                //Trace.WriteLine($"MouseY angle is: {MouseY}");
                if (isEnemyAlive(enemyIndexList+1)) 
                {
                    m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_MouseXOffset}", "float", MouseX.ToString());
                    m_memoryObj.WriteMemory($"base+{c_basePlayerOffset},{c_MouseYOffset}", "float", MouseY.ToString());
                }
            }
        }

        private playerCord GetEnemyCords(int enemyIndex) 
        {
            float x = m_memoryObj.ReadFloat($"{AddrOfEntityArrayAsString}+{(enemyIndex*4).ToString("X")},{c_XEastPositiveCordOffset}");
            float y = m_memoryObj.ReadFloat($"{AddrOfEntityArrayAsString}+{(enemyIndex*4).ToString("X")},{c_YNorthNegativeCordOffset}");
            float z = m_memoryObj.ReadFloat($"{AddrOfEntityArrayAsString}+{(enemyIndex*4).ToString("X")},{c_ZCordOffset}");
            return new playerCord() { x = x, y = y, z = z };
        }

        private bool isEnemyAlive(int enemyIndex) 
        {
            int health = m_memoryObj.ReadInt($"{AddrOfEntityArrayAsString}+{(enemyIndex * 4).ToString("X")},{c_HealthOffset}");
            Trace.TraceInformation($"Health of enemy is: {health}");
            return health > 0;
        }

        private List<playerCord> initPlayersList(int numOfEnemies) 
        {
            List<playerCord> playersList = new List<playerCord>();
            float x, y, z;
            int hp;
            for (int i = 0; i < numOfEnemies; ++i) 
            {
                x = m_memoryObj.ReadFloat($"{AddrOfEntityArrayAsString}+{((i + 1) * 4).ToString("X")},{c_XEastPositiveCordOffset}");
                y = m_memoryObj.ReadFloat($"{AddrOfEntityArrayAsString}+{((i + 1) * 4).ToString("X")},{c_YNorthNegativeCordOffset}");
                z = m_memoryObj.ReadFloat($"{AddrOfEntityArrayAsString}+{((i + 1) * 4).ToString("X")},{c_ZCordOffset}");
                hp = m_memoryObj.ReadInt($"{AddrOfEntityArrayAsString}+{((i + 1) * 4).ToString("X")},{c_HealthOffset}");
                playersList.Add(new playerCord() { x = x, y = y, z = z, health = hp});
            }

            return playersList;
        }
    }
}