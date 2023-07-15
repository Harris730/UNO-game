using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

using WMPLib;

namespace UnoGameFinal
{

    public partial class UnoWindow : Form
    {

        string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=univers;Integrated Security=True;Pooling=False";

        WindowsMediaPlayer WP = new WindowsMediaPlayer();
        WindowsMediaPlayer WP2 = new WindowsMediaPlayer();

        Form Parent;
        int i = 0;
        Player Player1;
        Player CPU;
        Player MiddleCardSetter;
        string Action = "";
        int Counter = 15;

        int r = 0;
        int g = 0;
        int b = 0;

        CardDeck CD = new CardDeck();  
        CardDeck DiscardPile = new CardDeck("Discard");
        Card MidCard = new Card();

        public UnoWindow(Form P, string s)
        {
            Parent = P;
            InitializeComponent();
            Action = s;
        }

        private void UnoWindow_Load(object sender, EventArgs e)
        {
            l_Loading.Visible = false;
            CD.ShuffleDeck();
            Player1 = new Player(CD);
            Player1.PlayerType = "Human";
            CPU = new Player(CD);
            CPU.PlayerType = "CPU";
            MiddleCardSetter = new Player(1, CD);

            PB_1.Image = Image.FromFile(Player1.PlayerHand[0].ImagePath);
            PB_1.Visible = false;
            lb_PlayerCards.Visible = false;
            listBoxUpdater();
            
        }

        private void SetMiddleCard()
        {
            MidCard.C_Color = MiddleCardSetter.PlayerHand[0].C_Color;
            MidCard.C_Type = MiddleCardSetter.PlayerHand[0].C_Type;
            MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + MiddleCardSetter.PlayerHand[i].C_Color.ToString() + @"\" + MiddleCardSetter.PlayerHand[i].C_Type.ToString() + @".png";
            if (MidCard.C_Type == CardType.Reverse || MidCard.C_Type == CardType.DrawTwo || MidCard.C_Type == CardType.DrawFour || MidCard.C_Type == CardType.Skip || MidCard.C_Type == CardType.Wild)
                MidCard.Special = "Yes";
            else
                MidCard.Special = "No";

            MiddleCardSetter.RemoveCard(MiddleCardSetter.PlayerHand[0].C_Color, MiddleCardSetter.PlayerHand[0].C_Type);
            PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + MidCard.C_Color.ToString() + @"\" + MidCard.C_Type.ToString() + @".png");
            
            if(MidCard.C_Type == CardType.DrawTwo)
            {
                Player1.AddCards(2, CD);
                PB_CPUTurnArrow.Visible = true;
                PB_PlayerTurnArrow.Visible = false;
                T_1.Start();
            }
            else if(MidCard.C_Type == CardType.DrawFour)
            {
                CPUChooseColor();
                Player1.AddCards(4, CD);
                PB_CPUTurnArrow.Visible = true;
                PB_PlayerTurnArrow.Visible = false;
                T_1.Start();
            }
            else if(MidCard.C_Type == CardType.Wild)
            {
                CPUChooseColor();
            }
            else if(MidCard.C_Type == CardType.Reverse || MidCard.C_Type == CardType.Skip)
            {
                T_1.Start();
                PB_CPUTurnArrow.Visible = true;
                PB_PlayerTurnArrow.Visible = false;
            }
            else
            {
                PB_CPUTurnArrow.Visible = false;
                PB_PlayerTurnArrow.Visible = true;
            }


            if (MidCard.C_Color == CardColor.Red)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Blue)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Green)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
            }
            else if (MidCard.C_Color == CardColor.Yellow)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
            }

            listBoxUpdater();
            DiscardPile.AddCardToDeck(MidCard.C_Color, MidCard.C_Type);

        }

        private void listBoxUpdater()
        {
            lb_PlayerCards.Items.Clear();
            PB_1.Image = null;
            for(int i =0; i<Player1.PlayerHand.Length;i++)
            {
                lb_PlayerCards.Items.Add(Player1.PlayerHand[i].C_Color.ToString() + "\t" + Player1.PlayerHand[i].C_Type.ToString());
            }
            lb_PlayerCardsRemaining.Text = Player1.PlayerHand.Length.ToString();
            lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
        }

        private void UnoWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Show();
        }

        private void T_1_Tick(object sender, EventArgs e)
        {
            
            DoCPUTurn();
        }

        private void CPUUno()
        {
            b_UnoCallout.Visible = false;
        }

        private void DoCPUTurn()
        {
            bool Played = false;
            for(int i=0; i<CPU.PlayerHand.Length;i++)
            {
                if(CPU.PlayerHand[i].Special == "Yes")
                {
                    if(CPU.PlayerHand[i].C_Type == MidCard.C_Type)
                    {
                        MidCard.C_Color = CPU.PlayerHand[i].C_Color;
                        MidCard.C_Type = CPU.PlayerHand[i].C_Type;
                        MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png";
                        MidCard.Special = "Yes";
                        PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png");

                        DiscardPile.AddCardToDeck(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);

                        CPU.RemoveCard(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);
                        Played = true;
                        Play_CardFlipPlay();
                        break;
                    }
                    else if(CPU.PlayerHand[i].C_Color == MidCard.C_Color)
                    {
                        MidCard.C_Color = CPU.PlayerHand[i].C_Color;
                        MidCard.C_Type = CPU.PlayerHand[i].C_Type;
                        MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png";
                        MidCard.Special = "Yes";
                        PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png");

                        DiscardPile.AddCardToDeck(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);

                        CPU.RemoveCard(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);
                        Played = true;
                        Play_CardFlipPlay();
                        break;
                    }
                    else if(CPU.PlayerHand[i].C_Color == CardColor.Neutral)
                    {
                        MidCard.C_Color = CPU.PlayerHand[i].C_Color;
                        MidCard.C_Type = CPU.PlayerHand[i].C_Type;
                        MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png";
                        MidCard.Special = "Yes";
                        PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png");

                        DiscardPile.AddCardToDeck(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);

                        CPU.RemoveCard(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);
                        Played = true;
                        Play_CardFlipPlay();
                        break;
                    }
                }
            }
            if(!Played)
            {
                for(int i =0;i<CPU.PlayerHand.Length;i++)
                {
                    if (CPU.PlayerHand[i].C_Type == MidCard.C_Type)
                    {

                        MidCard.C_Color = CPU.PlayerHand[i].C_Color;
                        MidCard.C_Type = CPU.PlayerHand[i].C_Type;
                        MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png";
                        MidCard.Special = "No";
                        PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png");

                        DiscardPile.AddCardToDeck(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);

                        CPU.RemoveCard(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);
                        Played = true;
                        Play_CardFlipPlay();
                        break;
                    }
                    else if (CPU.PlayerHand[i].C_Color == MidCard.C_Color)
                    {
                        MidCard.C_Color = CPU.PlayerHand[i].C_Color;
                        MidCard.C_Type = CPU.PlayerHand[i].C_Type;
                        MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png";
                        MidCard.Special = "No";
                        PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + CPU.PlayerHand[i].C_Color.ToString() + @"\" + CPU.PlayerHand[i].C_Type.ToString() + @".png");

                        DiscardPile.AddCardToDeck(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);

                        CPU.RemoveCard(CPU.PlayerHand[i].C_Color, CPU.PlayerHand[i].C_Type);
                        Played = true;
                        Play_CardFlipPlay();
                        break;
                    }
                }
            }
            if (!Played)
            {
                CPU.AddCards(1, CD);
                lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
                Play_CardFlipMidSound();
                bool checker = CheckCPUCards();
                if (!checker)
                    T_1.Stop();
            }
            else if (MidCard.C_Type == CardType.DrawTwo)
            {
                Player1.AddCards(2, CD);
                T_1.Stop();

                lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
                PB_CPUTurnArrow.Visible = false;
                PB_PlayerTurnArrow.Visible = true;

                PlayerSkipTurn();
            }
            else if (MidCard.C_Type == CardType.DrawFour)
            {
                Player1.AddCards(4, CD);
                CPUChooseColor();
                T_1.Stop();

                lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
                PB_CPUTurnArrow.Visible = false;
                PB_PlayerTurnArrow.Visible = true;

                PlayerSkipTurn();
            }
            else if (MidCard.C_Type == CardType.Reverse || MidCard.C_Type == CardType.Skip)
            {
                T_1.Stop();

                lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
                PB_CPUTurnArrow.Visible = false;
                PB_PlayerTurnArrow.Visible = true;

                PlayerSkipTurn();
            }
            else if(MidCard.C_Type == CardType.Wild)
            {
                CPUChooseColor();
                T_1.Stop();

                lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
                PB_CPUTurnArrow.Visible = false;
                PB_PlayerTurnArrow.Visible = true;
            }
            else
            {
                lb_CardsRemaingCPU.Text = CPU.PlayerHand.Length.ToString();
                PB_CPUTurnArrow.Visible = false;
                PB_PlayerTurnArrow.Visible = true;
                T_1.Stop();
            }
            if (Played == true)
            {
                DiscardPile.DiscardToDeck(CD);
                DiscardPile = new CardDeck("Discard");
                CD.ShuffleDeck();

                if (CPU.PlayerHand.Length == 1)
                {
                    b_UnoCallout.Visible = true;
                    t_CPUUno.Start();
                }
                if (CPU.PlayerHand.Length == 0)
                {
                    Winner(CPU.PlayerName);
                    AddWinnerToDatabase(CPU);
                }
            }
            listBoxUpdater();
            lb_PlayerCardsRemaining.Text = Player1.PlayerHand.Length.ToString();


            if (MidCard.C_Color == CardColor.Red)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Blue)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Green)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
            }
            else if(MidCard.C_Color == CardColor.Yellow)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
            }
        }

        private bool CheckCPUCards()
        {
            foreach (Card C in CPU.PlayerHand)
            {
                if (C.C_Color == MidCard.C_Color || C.C_Type == MidCard.C_Type || C.C_Color == CardColor.Neutral)
                {
                    PB_CPUTurnArrow.Visible = true;
                    PB_PlayerTurnArrow.Visible = false;
                    return true;
                }
            }
            PB_CPUTurnArrow.Visible = false;
            PB_PlayerTurnArrow.Visible = true;
            return false;
            
        }

        private void Winner(string Name)
        {

            T_1.Stop();
            T_Winner.Start();
            PB_1.Visible = false;
            lb_PlayerCards.Visible = false;
            PB_BeechMeCard.Visible = false;
            PB_CPUCard1.Visible = false;
            PB_CPUCard2.Visible = false;
            PB_CPUCard3.Visible = false;
            PB_CPUCard4.Visible = false;
            PB_BotPic1.Visible = false;
            PB_PlayerPic.Visible = false;
            PB_MidDeck.Visible = false;
            PB_PlayerTurnArrow.Visible = false;
            PB_CPUTurnArrow.Visible = false;
            PB_Color.Visible = false;
            lb_CardsRemaingCPU.Visible = false;
            lb_PlayerName.Visible = false;
            lb_BotName.Visible = false;
            lb_PlayerCardsRemaining.Visible = false;
            l_Counter.Visible = false;

            b_ChoiceBlue.Visible = false;
            b_ChoiceGreen.Visible = false; 
            b_ChoiceRed.Visible = false;
            b_ChoiceYellow.Visible = false;
            b_Uno.Visible = false;
            b_UnoCallout.Visible = false;

            l_WinnerName.Text = Name;
            l_WinnerName.Visible = true;
            l_Wins.Visible = true;
        }

        private void CPUChooseColor()
        {
            Random random = new Random();
            int r = random.Next(4);

            if (r == 0)
            {
                b_ChoiceRed.PerformClick();
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
                MidCard.C_Color = CardColor.Red;
            }
            if (r == 1)
            {
                b_ChoiceBlue.PerformClick();
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
                MidCard.C_Color = CardColor.Blue;
            }
            if (r == 2)
            {
                b_ChoiceGreen.PerformClick();
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
                MidCard.C_Color = CardColor.Green;
            }
            if (r == 3)
            {
                b_ChoiceYellow.PerformClick();
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
                MidCard.C_Color = CardColor.Yellow;
            }
        }

        private void PlayerSkipTurn()
        {
            PB_CPUTurnArrow.Visible = true;
            PB_PlayerTurnArrow.Visible = false;
            T_1.Start();
        }
        
        private void b_SubmitPlayerName_Click(object sender, EventArgs e)
        {
            Play_SciFiWaterSound();
            CPB_1.Visible = true;
            CPB_1.Value = 0;
            T_ProgressBar.Start();

            TB_1.Visible = false;
            b_SubmitPlayerName.Visible = false;
            PB_Choice0.Visible = false;
            PB_Choice1.Visible = false;
            PB_Choice2.Visible = false;
            PB_Choice3.Visible = false;
            PB_Choice4.Visible = false;
            PB_Choice5.Visible = false;
            PB_Choice6.Visible = false;
            PB_Choice7.Visible = false;
            PB_Choice8.Visible = false;
            PB_Choice9.Visible = false;
            lb_CharacterSelection.Visible = false;
            PB_SubmitGif1.Visible = false;
            PB_SubmitGif2.Visible = false;

        }

        private void GetBotName(Label l1)
        {
            string[] Text = File.ReadAllLines(@"F:\Mohammad\BUI 6\VP\UNO\BotNames\BotNames.txt");
            Random random = new Random();
            
            l1.Text = Text[random.Next(Text.Length)];
            CPU.PlayerName = l1.Text;
        }

        private void getPictureCPU(PictureBox P1)
        {
            Random random = new Random();
            P1.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BotPics\" + random.Next(10) + ".png");
        }

        private void lb_PlayerCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!T_1.Enabled && !T_Buffer.Enabled)
            {
                string temp = lb_PlayerCards.SelectedItem.ToString();
                string[] s = temp.Split('\t');
                PB_1.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + s[0] + @"\" + s[1] + @".png");
            }
        }

        private void lb_PlayerCards_DoubleClick(object sender, EventArgs e)
        {
            bool Played = false;
            if (!T_1.Enabled && !T_Buffer.Enabled)
            {
                string temp = lb_PlayerCards.SelectedItem.ToString();
                string[] s = temp.Split('\t');
                Action = "";

                foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
                {

                    if (s[0] == color.ToString())
                    {
                        foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
                        {
                            if (s[1] == cardType.ToString())
                            {
                                if (PB_BeechMeCard.Image == null)
                                {
                                    MidCard.C_Color = color;
                                    MidCard.C_Type = cardType;
                                    MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";
                                    if (cardType == CardType.Reverse || cardType == CardType.DrawTwo || cardType == CardType.DrawFour || cardType == CardType.Skip || cardType == CardType.Wild)
                                        MidCard.Special = "Yes";
                                    else
                                        MidCard.Special = "No";


                                    Player1.RemoveCard(color, cardType);
                                    PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png");
                                    listBoxUpdater();
                                    DiscardPile.AddCardToDeck(color, cardType);

                                    if (MidCard.C_Type == CardType.DrawFour || MidCard.C_Type == CardType.Wild)
                                    {
                                        b_ChoiceRed.Visible = true;
                                        b_ChoiceBlue.Visible = true;
                                        b_ChoiceGreen.Visible = true;
                                        b_ChoiceYellow.Visible = true;
                                    }
                                    Played = true;
                                    Play_CardFlipPlay();
                                    break;
                                }
                                else if (color == MidCard.C_Color)
                                {
                                    MidCard.C_Color = color;
                                    MidCard.C_Type = cardType;
                                    MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";
                                    if (cardType == CardType.Reverse || cardType == CardType.DrawTwo || cardType == CardType.DrawFour || cardType == CardType.Skip || cardType == CardType.Wild)
                                        MidCard.Special = "Yes";
                                    else
                                        MidCard.Special = "No";


                                    Player1.RemoveCard(color, cardType);
                                    PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png");
                                    listBoxUpdater();
                                    DiscardPile.AddCardToDeck(color, cardType);

                                    if (MidCard.C_Type == CardType.DrawFour || MidCard.C_Type == CardType.Wild)
                                    {
                                        b_ChoiceRed.Visible = true;
                                        b_ChoiceBlue.Visible = true;
                                        b_ChoiceGreen.Visible = true;
                                        b_ChoiceYellow.Visible = true;
                                    }
                                    Played = true;
                                    Play_CardFlipPlay();
                                    break;
                                }
                                else if (cardType == MidCard.C_Type)
                                {
                                    MidCard.C_Color = color;
                                    MidCard.C_Type = cardType;
                                    MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";
                                    if (cardType == CardType.Reverse || cardType == CardType.DrawTwo || cardType == CardType.DrawFour || cardType == CardType.Skip || cardType == CardType.Wild)
                                        MidCard.Special = "Yes";
                                    else
                                        MidCard.Special = "No";


                                    Player1.RemoveCard(color, cardType);
                                    PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png");
                                    listBoxUpdater();
                                    DiscardPile.AddCardToDeck(color, cardType);

                                    if (MidCard.C_Type == CardType.DrawFour || MidCard.C_Type == CardType.Wild)
                                    {
                                        b_ChoiceRed.Visible = true;
                                        b_ChoiceBlue.Visible = true;
                                        b_ChoiceGreen.Visible = true;
                                        b_ChoiceYellow.Visible = true;
                                    }
                                    Played = true;
                                    Play_CardFlipPlay();
                                    break;
                                }
                                else if (color == CardColor.Neutral)
                                {
                                    MidCard.C_Color = color;
                                    MidCard.C_Type = cardType;
                                    MidCard.ImagePath = @"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png";
                                    if (cardType == CardType.Reverse || cardType == CardType.DrawTwo || cardType == CardType.DrawFour || cardType == CardType.Skip || cardType == CardType.Wild)
                                        MidCard.Special = "Yes";
                                    else
                                        MidCard.Special = "No";


                                    Player1.RemoveCard(color, cardType);
                                    PB_BeechMeCard.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Cards\" + color.ToString() + @"\" + cardType.ToString() + @".png");
                                    listBoxUpdater();
                                    DiscardPile.AddCardToDeck(color, cardType);

                                    if (MidCard.C_Type == CardType.DrawFour || MidCard.C_Type == CardType.Wild)
                                    {
                                        b_ChoiceRed.Visible = true;
                                        b_ChoiceBlue.Visible = true;
                                        b_ChoiceGreen.Visible = true;
                                        b_ChoiceYellow.Visible = true;
                                    }
                                    Played = true;
                                    Play_CardFlipPlay();
                                    break;
                                }
                            }
                        }
                    }
                }
                if(Played == true)
                {
                    b_Pass.Visible = false;
                    if (MidCard.C_Type == CardType.DrawFour)
                    {
                        CPU.AddCards(4, CD);
                        PB_CPUTurnArrow.Visible = false;
                        PB_PlayerTurnArrow.Visible = true;
                        listBoxUpdater();
                    }
                    else if (MidCard.C_Type == CardType.DrawTwo)

                    {
                        CPU.AddCards(2, CD);
                        PB_CPUTurnArrow.Visible = false;
                        PB_PlayerTurnArrow.Visible = true;
                        listBoxUpdater();
                    }
                    else if (MidCard.C_Type == CardType.Skip || MidCard.C_Type == CardType.Reverse)
                    {
                        PB_CPUTurnArrow.Visible = false;
                        PB_PlayerTurnArrow.Visible = true;
                        listBoxUpdater();
                    }
                    else if(MidCard.C_Type == CardType.Wild)
                    {
                        PB_CPUTurnArrow.Visible = false;
                        PB_PlayerTurnArrow.Visible = true;
                        listBoxUpdater();
                    }
                    else
                    {
                        PB_CPUTurnArrow.Visible = true;
                        PB_PlayerTurnArrow.Visible = false;
                        T_1.Start();
                        listBoxUpdater();
                    }
                }
                lb_PlayerCardsRemaining.Text = Player1.PlayerHand.Length.ToString();

                if (MidCard.C_Color == CardColor.Red)
                {
                    PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
                }
                else if (MidCard.C_Color == CardColor.Blue)
                {
                    PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
                }
                else if (MidCard.C_Color == CardColor.Green)
                {
                    PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
                }
                else if (MidCard.C_Color == CardColor.Yellow)
                {
                    PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
                }
                if (Played == true)
                {
                    DiscardPile.DiscardToDeck(CD);
                    DiscardPile = new CardDeck("Discard");
                    CD.ShuffleDeck();

                    if (Player1.PlayerHand.Length == 1)
                    {
                        b_Uno.Visible = true;
                        t_CPUUno.Start();
                    }
                    if (Player1.PlayerHand.Length == 0)
                    {
                        Winner(Player1.PlayerName);
                        AddWinnerToDatabase(Player1);
                    }
                }
                T_Buffer.Start();
            }
        }

        private void TB_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                b_SubmitPlayerName.PerformClick();
            }
        }

        private void AddWinnerToDatabase(Player P)
        {
            SqlConnection  Con= new SqlConnection(cs);
            Con.Open();

            SqlCommand cmd = new SqlCommand("insert into Winners (Name,Date) values(@PlayerName, @Date)", Con);
            cmd.Parameters.AddWithValue("@PlayerName", P.PlayerName);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();

            Con.Close();

        }

        private void PB_Choice_Click(object sender, EventArgs e)
        {
            PB_Choice0.BorderStyle = BorderStyle.None;
            PB_Choice1.BorderStyle = BorderStyle.None;
            PB_Choice2.BorderStyle = BorderStyle.None;
            PB_Choice3.BorderStyle = BorderStyle.None;
            PB_Choice4.BorderStyle = BorderStyle.None;
            PB_Choice5.BorderStyle = BorderStyle.None;
            PB_Choice6.BorderStyle = BorderStyle.None;
            PB_Choice7.BorderStyle = BorderStyle.None;
            PB_Choice8.BorderStyle = BorderStyle.None;
            PB_Choice9.BorderStyle = BorderStyle.None;

            PictureBox pictureBox = sender as PictureBox;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            PB_PlayerPic.Image = pictureBox.Image;
            
        }

        private void lb_PlayerCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lb_PlayerCards_DoubleClick(sender, e);
            }
        }

        private void PB_MidDeck_DoubleClick(object sender, EventArgs e)
        {
            if (!T_1.Enabled && !T_Buffer.Enabled && b_ChoiceRed.Visible == false)
            {
                Player1.AddCards(1, CD);
                listBoxUpdater();
                PB_CPUTurnArrow.Visible = true;
                PB_PlayerTurnArrow.Visible = false;
                Play_CardFlipMidSound();
                SearchPlayerHand();
                if (b_Pass.Visible == true)
                {
                    PB_CPUTurnArrow.Visible = false;
                    PB_PlayerTurnArrow.Visible = true;
                }
            }
        }

        private void SearchPlayerHand()
        {
            foreach(Card C in Player1.PlayerHand)
            {
                if(C.C_Color == MidCard.C_Color)
                    b_Pass.Visible = true;
                else if(C.C_Type == MidCard.C_Type)
                    b_Pass.Visible=true;
                else if(C.C_Color == CardColor.Neutral)
                    b_Pass.Visible = true;
            }
            if(b_Pass.Visible == false)
                T_1.Start();
        }

        private void b_ChoiceRed_Click(object sender, EventArgs e)
        {
            b_ChoiceRed.Visible = false;
            b_ChoiceBlue.Visible = false;
            b_ChoiceGreen.Visible = false;
            b_ChoiceYellow.Visible = false;

            MidCard.C_Color = CardColor.Red;
            if (MidCard.C_Type == CardType.Wild)
            {
                T_1.Start();
            }

            if (MidCard.C_Color == CardColor.Red)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Blue)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Green)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
            }
            else if (MidCard.C_Color == CardColor.Yellow)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
            }

            if (MidCard.C_Type == CardType.Wild)
            {
                PB_PlayerTurnArrow.Visible = false;
                PB_CPUTurnArrow.Visible = true;
            }
            else
            {
                PB_PlayerTurnArrow.Visible = true;
                PB_CPUTurnArrow.Visible = false;
            }
        }

        private void b_ChoiceBlue_Click(object sender, EventArgs e)
        {
            b_ChoiceRed.Visible = false;
            b_ChoiceBlue.Visible = false;
            b_ChoiceGreen.Visible = false;
            b_ChoiceYellow.Visible = false;

            MidCard.C_Color = CardColor.Blue;
            if (MidCard.C_Type == CardType.Wild)
            {
                T_1.Start();
            }

            if (MidCard.C_Color == CardColor.Red)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Blue)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Green)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
            }
            else if (MidCard.C_Color == CardColor.Yellow)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
            }

            if (MidCard.C_Type == CardType.Wild)
            {
                PB_PlayerTurnArrow.Visible = false;
                PB_CPUTurnArrow.Visible = true;
            }
            else
            {
                PB_PlayerTurnArrow.Visible = true;
                PB_CPUTurnArrow.Visible = false;
            }
        }

        private void b_ChoiceGreen_Click(object sender, EventArgs e)
        {
            b_ChoiceRed.Visible = false;
            b_ChoiceBlue.Visible = false;
            b_ChoiceGreen.Visible = false;
            b_ChoiceYellow.Visible = false;

            MidCard.C_Color = CardColor.Green;
            if (MidCard.C_Type == CardType.Wild)
            {
                T_1.Start();
            }

            if (MidCard.C_Color == CardColor.Red)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Blue)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Green)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
            }
            else if (MidCard.C_Color == CardColor.Yellow)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
            }

            if (MidCard.C_Type == CardType.Wild)
            {
                PB_PlayerTurnArrow.Visible = false;
                PB_CPUTurnArrow.Visible = true;
            }
            else
            {
                PB_PlayerTurnArrow.Visible = true;
                PB_CPUTurnArrow.Visible = false;
            }
        }

        private void b_ChoiceYellow_Click(object sender, EventArgs e)
        {
            b_ChoiceRed.Visible = false;
            b_ChoiceBlue.Visible = false;
            b_ChoiceGreen.Visible = false;
            b_ChoiceYellow.Visible = false;

            MidCard.C_Color = CardColor.Yellow;
            if (MidCard.C_Type == CardType.Wild)
            {
                T_1.Start();
            }

            if (MidCard.C_Color == CardColor.Red)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Red Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Blue)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Blue Circle.png");
            }
            else if (MidCard.C_Color == CardColor.Green)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\GreenCircle.png");
            }
            else if (MidCard.C_Color == CardColor.Yellow)
            {
                PB_Color.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Yellow Circle.png");
            }

            if (MidCard.C_Type == CardType.Wild)
            {
                PB_PlayerTurnArrow.Visible = false;
                PB_CPUTurnArrow.Visible = true;
            }
            else
            {
                PB_PlayerTurnArrow.Visible = true;
                PB_CPUTurnArrow.Visible = false;
            }
        }

        private void PB_Color_MouseHover(object sender, EventArgs e)
        {
            l_ColorIndicator.Visible = true;
        }

        private void PB_Color_MouseLeave(object sender, EventArgs e)
        {
            l_ColorIndicator.Visible = false;
        }

        private void PB_MidDeck_MouseHover(object sender, EventArgs e)
        {
            l_DeckToolTip.Visible = true;
        }

        private void PB_MidDeck_MouseLeave(object sender, EventArgs e)
        {
            l_DeckToolTip.Visible = false;
        }

        private void T_Buffer_Tick(object sender, EventArgs e)
        {
            T_Buffer.Stop();
        }

        private void b_Uno_Click(object sender, EventArgs e)
        {
            b_Uno.Visible = false;
        }

        private void b_UnoCallout_Click(object sender, EventArgs e)
        {
            CPU.AddCards(2, CD);
            listBoxUpdater();
            b_UnoCallout.Visible = false;
        }

        private void t_CPUUno_Tick(object sender, EventArgs e)
        {
            if (b_Uno.Visible)
            {
                Player1.AddCards(2, CD);
                b_Uno.Visible = false;
                listBoxUpdater();
            }
            if (b_UnoCallout.Visible)
            {
                CPUUno();
            }
            t_CPUUno.Stop();
        }

        private void Play_CardFlipMidSound()
        {
            WP.URL = @"F:\Mohammad\BUI 6\VP\UNO\Sound Effects\84322__splashdust__flipcard.wav";
            WP.controls.play();
        }

        private void Play_CardFlipPlay()
        {
            WP.URL = @"F:\Mohammad\BUI 6\VP\UNO\Sound Effects\240776__f4ngy__card-flip.wav";
            WP.controls.play();
        }

        private void T_HotPotato_Tick(object sender, EventArgs e)
        {
            if (Counter != 0)
            {
                Counter = Counter - 1;
                if(Counter == 3)
                    l_Counter.ForeColor = Color.Red;
                l_Counter.Text = Counter.ToString();
            }
            else if (Counter == 0)
            {
                Counter = 15;
                l_Counter.Text = Counter.ToString();
                if (T_1.Enabled)
                {
                    CPU.AddCards(1, CD);
                    listBoxUpdater();
                }
                else
                {
                    Player1.AddCards(1, CD);
                    listBoxUpdater();
                }
                l_Counter.ForeColor=Color.Black;
            }
        }

        private void T_Winner_Tick(object sender, EventArgs e)
        {
            Random rc = new Random();
            r = rc.Next(0, 256);
            g = rc.Next(0, 256);
            b = rc.Next(0, 256);
            l_WinnerName.ForeColor = Color.FromArgb(r, g, b);
            l_Wins.ForeColor = Color.FromArgb(r, g, b);
        }

        private void b_SubmitPlayerName_MouseMove(object sender, MouseEventArgs e)
        {
            b_SubmitPlayerName.Font = new Font(b_SubmitPlayerName.Font.FontFamily, 20, b_SubmitPlayerName.Font.Style);
            b_SubmitPlayerName.Size = new Size(168, 71);
            b_SubmitPlayerName.Location = new Point(620, 669);
            PB_SubmitGif1.Visible = true;
            PB_SubmitGif2.Visible = true;
        }

        private void b_SubmitPlayerName_MouseLeave(object sender, EventArgs e)
        {
            PB_SubmitGif1.Visible = false;
            PB_SubmitGif2.Visible = false;
            b_SubmitPlayerName.Font = new Font(b_SubmitPlayerName.Font.FontFamily, 16, b_SubmitPlayerName.Font.Style);
            b_SubmitPlayerName.Size = new Size(138, 51);
            b_SubmitPlayerName.Location = new Point(630, 669);
        }

        private void T_ProgressBar_Tick(object sender, EventArgs e)
        {
            CPB_1.Value += 1;
            if (CPB_1.Value < 100)
            {
                CPB_1.Text = CPB_1.Value.ToString() + "%";
            }
            if(CPB_1.Value == 100)
            {
                CPB_1.Text = CPB_1.Value.ToString() + "%";
                T_ProgressBar.Stop();
                T_LOL.Start();
                
            }
        }

        private void T_LOL_Tick(object sender, EventArgs e)
        {
            T_LOL.Stop();

            CPB_1.Visible = false;
            if (Action == "Special")
            {
                T_HotPotato.Start();
                l_Counter.Visible = true;
                l_Counter.Text = Counter.ToString();
            }
            SetMiddleCard();

            Player1.PlayerName = TB_1.Text;

            PB_1.Visible = true;
            lb_PlayerCards.Visible = true;
            PB_BeechMeCard.Visible = true;
            PB_CPUCard1.Visible = true;
            PB_CPUCard2.Visible = true;
            PB_CPUCard3.Visible = true;
            PB_CPUCard4.Visible = true;
            PB_BotPic1.Visible = true;
            PB_PlayerPic.Visible = true;
            PB_MidDeck.Visible = true;
            PB_Color.Visible = true;
            lb_CardsRemaingCPU.Visible = true;
            lb_PlayerName.Visible = true;
            lb_PlayerName.Text = Player1.PlayerName;
            lb_BotName.Visible = true;
            lb_PlayerCardsRemaining.Visible = true;
            GetBotName(lb_BotName);
            getPictureCPU(PB_BotPic1);

            PB_Submit.Visible = false;
            this.BackgroundImage = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\BG\GameTable.jpg");
        }

        private void b_Pass_Click(object sender, EventArgs e)
        {
            b_Pass.Visible = false;
            T_1.Start();
            PB_CPUTurnArrow.Visible = true;
            PB_PlayerTurnArrow.Visible = false;
        }

        private void b_Pass_MouseHover(object sender, EventArgs e)
        {
            l_PassTurn.Visible = true;
        }

        private void b_Pass_MouseLeave(object sender, EventArgs e)
        {
            l_PassTurn.Visible = false;
        }

        private void b_ExitThisForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ExitThisForm_MouseLeave(object sender, EventArgs e)
        {
            b_ExitThisForm.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Door.png");
        }

        private void b_ExitThisForm_MouseMove(object sender, MouseEventArgs e)
        {
            Play_ArcadeEffectSound();
            b_ExitThisForm.Image = Image.FromFile(@"F:\Mohammad\BUI 6\VP\UNO\Button Icons\Door_Lightened.png");
        }

        private void Play_SciFiWaterSound()
        {
            WP2.URL = @"F:\Mohammad\BUI 6\VP\UNO\Sound Effects\mixkit-water-sci-fi-bleep-902.wav";
            WP2.controls.play();
        }

        private void Play_ArcadeEffectSound()
        {
            WP.URL = @"F:\Mohammad\BUI 6\VP\UNO\Sound Effects\mixkit-arcade-game-jump-coin-216.wav";
            WP.controls.play();
        }

        private void PB_Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
