using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class blackjack : Form
    {
        //Client zmienne
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        Thread newThread;
        bool client;
        Thread gameOver;
        bool host;
        int p1wins = 0;
        int p2wins = 0;

        //Zmienne rozgrywki
        Random random = new Random();
        int r1dice1 = 0;
        int r1dice2 = 0;
        int r2dice1 = 0;
        int r2dice2 = 0;
        int score = 0;
        string myResult = null;
        int enemyAction1 = 0;
        int enemyAction2 = 0;
        int enemyScore = 0;
        string enemyName = null;
        bool gameEnded = true;
        bool p1over;
        bool p2over;
        bool p1playAgain;
        bool p2playAgain;
        int revengeCounter = 0;

        //Host zmienne
        public static Hashtable clientsList = new Hashtable();
        Thread hostThread;
        bool wait = true;
        IPAddress hostAddress;
        Int32 hostPort;

        public blackjack()
        {
            InitializeComponent();

            gameOver = new Thread(new ThreadStart(gameOverCheck));
            gameOver.IsBackground = true;
            gameOver.Start();
        }

        private void gameOverCheck()
        {
            while(gameEnded == true)
            {
                if (p1over == true && p2over == true)
                {
                    gameResult();
                    gameEnded = false;
                    revengeButton();
                }
                Thread.Sleep(1000);
            }

            while(gameEnded == false)
            {
                if(p1playAgain == true && p2playAgain == true)
                {
                    gameEnded = true;
                    playAgain();
                    gameOverCheck();
                }
                Thread.Sleep(1000);
            }
        }

        private void revengeButton()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(revengeButton));
            else
            {
                revenge.Visible = true;
            }
        }

        private void playAgain()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(playAgain));
            else
            {
                waitLabel.Visible = false;

                //Reset zmiennych do domyślnych wartości
                random = new Random();
                r1dice1 = 0;
                r1dice2 = 0;
                r2dice1 = 0;
                r2dice2 = 0;
                score = 0;
                myResult = null;
                enemyAction1 = 0;
                enemyAction2 = 0;
                enemyScore = 0;
                enemyName = null;
                gameEnded = true;
                p1over = false;
                p2over = false;
                p1playAgain = false;
                p2playAgain = false;
                revengeCounter = 0;

                //Reset okna do domyślnych wartości
                action1.Enabled = true;
                p1r1Dice2.Text = "0";
                p1r1Dice2.Visible = true;
                p1r1Dice1.Text = "0";
                p1r1Dice1.Visible = true;
                action1separator.Visible = true;
                action1number.Text = "0";
                action1number.Visible = false;
                p1result.Visible = false;

                action2number.Text = "0";
                action2number.Visible = false;
                action2Separator.Visible = true;

                p1r2Dice1.Visible = true;
                p1r2Dice2.Visible = true;
                p1r2Dice1.Checked = false;
                p1r2Dice2.Checked = false;
                p1r2Dice1.Text = "0";
                p1r2Dice2.Text = "0";
                p1score.Text = "0";


                enemy1.Text = "0";
                enemy1.Visible = false;
                enemy2.Text = "0";
                enemy2.Visible = false;
                enemy3.Text = "0";
                enemy3.Visible = false;
                p2result.Visible = false;
            }
        }

        private void blackjack_Load(object sender, EventArgs e)
        {
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clientSocket.Connected)
            {
                clientSocket.Close();
                serverStream.Close();
                newThread.Abort();
            }
            Application.Exit();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            hostAddress = IPAddress.Parse(address.Text);
            hostPort = Convert.ToInt32(port.Text);
            
            try
            {
                TcpListener testListening = new TcpListener(hostAddress, hostPort);
                testListening.Start();
                testListening.Stop();
                client = false;
            }
            catch
            {
                client = true;
            }

            if (client == false)
            {
                try
                {
                    TcpClient testConnection = new TcpClient();
                    testConnection.Connect(IPAddress.Parse(address.Text), Convert.ToInt32(port.Text));
                    testConnection.Close();
                }
                catch
                {
                    hostThread = new Thread(hosting);
                    hostThread.Start();
                }
            }

            if (client == false)
            {
                while (wait)
                {

                }
            }

            try
            {
                IPAddress connectionAddress = IPAddress.Parse(address.Text);
                Int32 connectionPort = Convert.ToInt32(port.Text);
                string connectionNick = nick.Text;

                clientSocket.Connect(connectionAddress, connectionPort);
                serverStream = clientSocket.GetStream();
                byte[] outStream = null;

                if (connectionNick.Length > 15)
                {
                    outStream = Encoding.UTF8.GetBytes(connectionNick.Substring(0, 15) + "$");
                    player1Name.Text = connectionNick.Substring(0, 15);
                }
                else
                {
                    outStream = Encoding.UTF8.GetBytes(connectionNick + "$");
                    player1Name.Text = connectionNick;
                }

                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                newThread = new Thread(getMessage);
                newThread.Start();

                connect.Enabled = false;
                nick.Enabled = false;
                address.Enabled = false;
                port.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nie można nawiązać połączenia z serwerem");
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (messageBox.Text != "")
            {
                try
                {
                    byte[] outStream = Encoding.UTF8.GetBytes("████msg" + messageBox.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();
                    messageBox.Text = "";
                }
                catch
                {

                }

                messageBox.Text = "";
            }
        }

        private void getMessage()
        {
            newThread.IsBackground = true;

            while (true)
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    int buffSize = 0;
                    byte[] inStream = new byte[100025];
                    buffSize = clientSocket.ReceiveBufferSize;
                    serverStream.Read(inStream, 0, buffSize);
                    string returndata = Encoding.UTF8.GetString(inStream);
                    readData = "" + returndata;

                    string systemChecker = null;
                    string userNameDetector = null;

                    for (int i = 0; i < 7; i++)
                    {
                        systemChecker += readData[i];
                    }

                    for(int i = 0; i < 4; i++)
                    {
                        userNameDetector += readData[i];
                    }

                    if(systemChecker != "█SysInf" && systemChecker != "█Reveng" && userNameDetector != "█<< ")
                    {
                        msg();
                    }
                    else if (systemChecker == "█SysInf")
                    {
                        playerInfoWriter();
                    }
                    else if(systemChecker == "█Reveng")
                    {
                        revengeCounter++;

                        if(revengeCounter == 2)
                        {
                            p1playAgain = true;
                            p2playAgain = true;
                        }
                    }
                    else if(userNameDetector == "█<< ")
                    {
                         enemyNameWriter();                
                    }
                }
                catch
                {
                    if (clientSocket.Connected)
                    {
                        clientSocket.Close();
                        serverStream.Close();
                        newThread.Abort();
                    }
                    Application.Exit();
                }
            }
        }

        private void p1winner()
        {
            p1result.Text = "Wygrana!";
            p1result.ForeColor = Color.LightGreen;
            p1result.Visible = true;
            p1wins += 1;
            p1winsCounter.Text = Convert.ToString(p1wins);
        }

        private void p1looser()
        {
            p1result.Text = "Przegrana!";
            p1result.ForeColor = Color.Red;
            p1result.Visible = true;
        }

        private void p2winner()
        {
            p2result.Text = "Wygrana!";
            p2result.ForeColor = Color.LightGreen;
            p2result.Visible = true;
            p2wins += 1;
            p2winsCounter.Text = Convert.ToString(p2wins);
        }

        private void p2looser()
        {
            p2result.Text = "Przegrana!";
            p2result.ForeColor = Color.Red;
            p2result.Visible = true;
        }

        private void draw()
        {
            p1result.Text = "Remis!";
            p1result.ForeColor = Color.White;
            p2result.Text = "Remis!";
            p2result.ForeColor = Color.White;
            p1result.Visible = true;
            p2result.Visible = true;
        }


        private void gameResult()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(gameResult));
            else
            {
                if (p1score.Text == enemy3.Text)
                {
                    draw();
                }


                if (Convert.ToInt32(enemy3.Text) > Convert.ToInt32(p1score.Text))
                {
                    if (Convert.ToInt32(enemy3.Text) > 21 && Convert.ToInt32(p1score.Text) > 21)
                    {
                        p1winner();
                        p2looser();
                    }
                    else if(Convert.ToInt32(enemy3.Text) > 21 && Convert.ToInt32(p1score.Text) < 21)
                    {
                        p1winner();
                        p2looser();
                    }
                    else if (Convert.ToInt32(enemy3.Text) < 21 && Convert.ToInt32(p1score.Text) > 21)
                    {
                        p1looser();
                        p2winner();
                    }
                    else if(Convert.ToInt32(enemy3.Text) < 21 && Convert.ToInt32(p1score.Text) < 21)
                    {
                        p1looser();
                        p2winner();
                    }
                    else
                    {
                        if (Convert.ToInt32(enemy3.Text) == 21)
                        {
                            p1looser();
                            p2winner();
                        }
                        else
                        {
                            p1winner();
                            p2looser();
                        }
                    }

                }
                else if(Convert.ToInt32(enemy3.Text) < Convert.ToInt32(p1score.Text))
                {
                    if (Convert.ToInt32(enemy3.Text) > 21 && Convert.ToInt32(p1score.Text) > 21)
                    {
                        p1looser();
                        p2winner();
                    }
                    else if (Convert.ToInt32(enemy3.Text) > 21 && Convert.ToInt32(p1score.Text) < 21)
                    {
                        p1winner();
                        p2looser();
                    }
                    else if (Convert.ToInt32(enemy3.Text) < 21 && Convert.ToInt32(p1score.Text) > 21)
                    {
                        p1looser();
                        p2winner();
                    }
                    else if (Convert.ToInt32(enemy3.Text) < 21 && Convert.ToInt32(p1score.Text) < 21)
                    {
                        p1winner();
                        p2looser();
                    }
                    else
                    {
                        if (Convert.ToInt32(enemy3.Text) == 21)
                        {
                            p1looser();
                            p2winner();
                        }
                        else
                        {
                            p1winner();
                            p2looser();
                        }
                    }
                }
            }
        }

        private void enemyNameWriter()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(enemyNameWriter));
            else
            {
                readData = readData.Remove(0, 1);
                msg();

                string[] nameArray = null;

                nameArray = readData.Split(' ');

                if(nick.Text != nameArray[1])
                {
                    player2Name.Text = nameArray[1];
                    send.Enabled = true;
                    action1.Enabled = true;
                }
            }     
        }

        private void msg()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(msg));
            else
            {
                readData = readData.Replace("████msg", "");

                if (chatBox.Text == "")
                {
                    chatBox.AppendText(readData);
                }
                else
                {
                    chatBox.AppendText(Environment.NewLine + readData);
                }

                chatBox.SelectionStart = chatBox.Text.Length;
                chatBox.ScrollToCaret();
            }
        }

        private void playerInfoWriter()
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(playerInfoWriter));
            else
            {
                string[] enemy = readData.Split('|');

                //Kolejność danych:
                //nazwaGracza|akcja1|akcja2 -> | separator danych

                enemyName = enemy[1];

                if (enemyName != nick.Text)
                {
                    enemy1.Text = enemy[2];
                    enemy2.Text = enemy[3];
                    enemyScore = Convert.ToInt32(enemy[2]) + Convert.ToInt32(enemy[3]);
                    enemy3.Text = Convert.ToString(enemyScore);

                    enemy1.Visible = true;
                    enemy2.Visible = true;
                    enemy3.Visible = true;

                    p2over = true;
                }
            }
        }

        private void hosting()
        {
            hostThread.IsBackground = true;

            TcpListener hostServer = new TcpListener(hostAddress, hostPort);
            TcpClient hostClient = default(TcpClient);

            hostServer.Start();

            int  counter = 0;

            while(counter <= 2)
            {
                wait = false;

                hostClient = hostServer.AcceptTcpClient();

                byte[] bytesFromClient = new byte[1000025];
                string dataFromClient = null;

                NetworkStream hostStream = hostClient.GetStream();
                hostStream.Read(bytesFromClient, 0, hostClient.ReceiveBufferSize);
                dataFromClient = Encoding.UTF8.GetString(bytesFromClient);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                clientsList.Add(dataFromClient, hostClient);


                if (counter == 1)
                {
                    broadcast("█<< " + nick.Text + " >>" + " dołączył do gry!", dataFromClient, false);
                    broadcast("█<< " + dataFromClient + " >>" + " dołączył do gry!", dataFromClient, false);
                }

                handleClinet client = new handleClinet();
                client.startClient(hostClient, dataFromClient, clientsList);

                counter++;
            }

            hostClient.Close();
            hostServer.Stop();
        }

        public static void broadcast(string message, string uName, bool firstMessage)
        {
            foreach (DictionaryEntry Item in clientsList)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)Item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;
                DateTime data = DateTime.UtcNow.ToLocalTime();

                if (firstMessage == true)
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(data.ToString("hh:mm:ss") + " " + uName + " : " + message);
                }
                else
                {
                    broadcastBytes = Encoding.UTF8.GetBytes(message);
                }

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }

        private void action1_Click(object sender, EventArgs e)
        {
            action1.Enabled = false;
            action2.Enabled = true;
            r1dice1 = random.Next(1, 1000) % 6 + 1;
            r1dice2 = random.Next(1, 1000) % 6 + 1;
            score += (r1dice1 + r1dice2) * 2;
            enemyAction1 = score;
            action1number.Text = Convert.ToString(score);

            p1r1Dice2.Enabled = true;
            p1r1Dice1.Enabled = true;
            p1score.Enabled = true;

            p1r1Dice1.Text = Convert.ToString(r1dice1);
            p1r1Dice2.Text = Convert.ToString(r1dice2);
            p1score.Text = Convert.ToString(score);

            setImages(r1dice1, r1dice2);
        }

        private void setImages(int d1, int d2)
        {
            diceImage(dice1, d1);
            diceImage(dice2, d2);
        }

        private void diceImage(PictureBox dice, int points)
        {
            if (points == 0) dice.Image = Properties.Resources.diceForm_resized;
            else if (points == 1) dice.Image = Properties.Resources.dice1_resized;
            else if (points == 2) dice.Image = Properties.Resources.dice2_resized;
            else if (points == 3) dice.Image = Properties.Resources.dice3_resized;
            else if (points == 4) dice.Image = Properties.Resources.dice4_resized;
            else if (points == 5) dice.Image = Properties.Resources.dice5_resized;
            else if (points == 6) dice.Image = Properties.Resources.dice6_resized;
            dice.Refresh();
        }

        private void p1r1Dice1_Click(object sender, EventArgs e)
        {

        }

        private void action2_Click(object sender, EventArgs e)
        {
            action2.Enabled = false;
            action3.Enabled = true;
            p1r2Dice1.Enabled = true;
            p1r2Dice2.Enabled = true;
            r2dice1 = random.Next(1, 1000) % 6 + 1;
            r2dice2 = random.Next(1, 1000) % 6 + 1;

            p1r2Dice1.Text = Convert.ToString(r2dice1);
            p1r2Dice2.Text = Convert.ToString(r2dice2);

            setImages(r2dice1, r2dice2);
        }

        private void p1r2Dice1_CheckedChanged(object sender, EventArgs e)
        {
            p1score.Text = Convert.ToString(score + r2dice1);
        }

        private void p1r2Dice2_CheckedChanged(object sender, EventArgs e)
        {
            p1score.Text = Convert.ToString(score + r2dice2);
        }

        private void action3_Click(object sender, EventArgs e)
        {
            if (p1r2Dice1.Checked || p1r2Dice2.Checked)
            {
                action3.Enabled = false;
                p1r2Dice1.Enabled = false;
                p1r2Dice2.Enabled = false;
                p1r2Dice1.Visible = false;
                p1r2Dice2.Visible = false;
                action2Separator.Visible = false;
                action1separator.Visible = false;
                p1r1Dice1.Visible = false;
                p1r1Dice2.Visible = false;

                action2number.Visible = true;
                action1number.Visible = true;

                if (p1r2Dice1.Checked)
                {
                    score += r2dice1;
                    action2number.Text = Convert.ToString(r2dice1);
                    enemyAction2 = r2dice1;
                }
                else
                {
                    score += r2dice2;
                    action2number.Text = Convert.ToString(r2dice2);
                    enemyAction2 = r2dice2;
                }

                p1score.Text = Convert.ToString(score);

                if (enemyScore == 0)
                {
                    p1result.Text = "Oczekiwanie...";
                    p1result.ForeColor = Color.White;
                    p1result.Visible = true;
                }

                //Wysyłanie informacji do serwera o wyniku
                //Kolejność danych:
                //nazwaGracza|akcja1|akcja2 -> | separator danych

                myResult = "█SysInf" + "|" + nick.Text + "|" + enemyAction1 + "|" + enemyAction2;

                try
                {
                    byte[] outStream = Encoding.UTF8.GetBytes(myResult + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();
                }
                catch
                {

                }

                p1over = true;
                setImages(0, 0);
            }
            else
            {
                MessageBox.Show("Wybierz wartość w rzucie nr 2!");
            }
        }

        private void revenge_Click(object sender, EventArgs e)
        {
            try
            {
                revenge.Visible = false;
                waitLabel.Visible = true;
                byte[] outStream = Encoding.UTF8.GetBytes("█Reveng" + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }
            catch
            {

            }
        }
    }

    public class handleClinet
    {
        TcpClient clientSocket;
        string clNo;
        Hashtable clientsList;
        public static Thread chatThread;

        public void startClient(TcpClient inClientSocket, string clineNo, Hashtable cList)
        {
            clientSocket = inClientSocket;
            clNo = clineNo;
            clientsList = cList;
            chatThread = new Thread(doChat);
            chatThread.Start();
        }

        private void doChat()
        {
            chatThread.IsBackground = true;

            byte[] bytesFromClient = new byte[100025];
            string dataFromClient = null;

            while (true)
            {
                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFromClient, 0, clientSocket.ReceiveBufferSize);
                    dataFromClient = Encoding.UTF8.GetString(bytesFromClient);

                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    string systemChecker = null;

                    for (int i = 0; i < 7; i++)
                    {
                        systemChecker += dataFromClient[i];
                    }

                    if(systemChecker != "█SysInf" && systemChecker != "█Reveng")
                    {
                        blackjack.broadcast(dataFromClient, clNo, true);
                    }
                    else if (systemChecker == "█SysInf")
                    {
                        blackjack.broadcast(dataFromClient, clNo, false);
                    }
                    else if(systemChecker == "█Reveng")
                    {
                        blackjack.broadcast(dataFromClient, clNo, false);
                    }
                }
                catch
                {

                }

            }
        }
    }
}
