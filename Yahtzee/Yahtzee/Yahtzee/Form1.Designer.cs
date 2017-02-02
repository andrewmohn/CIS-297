namespace Yahtzee
{
    partial class yahtzeeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonRoll = new System.Windows.Forms.Button();
            this.saveAsTextBox = new System.Windows.Forms.ComboBox();
            this.ScoreLabelAces = new System.Windows.Forms.Label();
            this.ScoreLabelTwos = new System.Windows.Forms.Label();
            this.ScoreLabelThrees = new System.Windows.Forms.Label();
            this.ScoreLabelFours = new System.Windows.Forms.Label();
            this.ScoreLabelFives = new System.Windows.Forms.Label();
            this.ScoreLabelSixes = new System.Windows.Forms.Label();
            this.ScoreLabelThreeOfAKind = new System.Windows.Forms.Label();
            this.BoxUpperSection = new System.Windows.Forms.GroupBox();
            this.scoreSixes = new System.Windows.Forms.Label();
            this.scoreFives = new System.Windows.Forms.Label();
            this.scoreFours = new System.Windows.Forms.Label();
            this.scoreThrees = new System.Windows.Forms.Label();
            this.scoreTwos = new System.Windows.Forms.Label();
            this.scoreAces = new System.Windows.Forms.Label();
            this.BoxLowerSection = new System.Windows.Forms.GroupBox();
            this.chanceScore = new System.Windows.Forms.Label();
            this.YahtzeeScore = new System.Windows.Forms.Label();
            this.largeStraightScore = new System.Windows.Forms.Label();
            this.smallStraightScore = new System.Windows.Forms.Label();
            this.fullHouseScore = new System.Windows.Forms.Label();
            this.fourOfAKindScore = new System.Windows.Forms.Label();
            this.threeOfAKindScore = new System.Windows.Forms.Label();
            this.ScoreLabelChance = new System.Windows.Forms.Label();
            this.ScoreLabelYahtzee = new System.Windows.Forms.Label();
            this.ScoreLabelLargeStraight = new System.Windows.Forms.Label();
            this.ScoreLabelSmallStraight = new System.Windows.Forms.Label();
            this.ScoreLableFullHouse = new System.Windows.Forms.Label();
            this.ScoreLableFourOfAKind = new System.Windows.Forms.Label();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.diceBox = new System.Windows.Forms.GroupBox();
            this.dieFive = new System.Windows.Forms.Label();
            this.dieFour = new System.Windows.Forms.Label();
            this.dieThree = new System.Windows.Forms.Label();
            this.dieTwo = new System.Windows.Forms.Label();
            this.dieOne = new System.Windows.Forms.Label();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.finalScore = new System.Windows.Forms.Label();
            this.BoxUpperSection.SuspendLayout();
            this.BoxLowerSection.SuspendLayout();
            this.diceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRoll
            // 
            this.ButtonRoll.Location = new System.Drawing.Point(68, 357);
            this.ButtonRoll.Name = "ButtonRoll";
            this.ButtonRoll.Size = new System.Drawing.Size(75, 23);
            this.ButtonRoll.TabIndex = 0;
            this.ButtonRoll.Text = "Roll";
            this.ButtonRoll.UseVisualStyleBackColor = true;
            this.ButtonRoll.Click += new System.EventHandler(this.ButtonRoll_Click);
            // 
            // saveAsTextBox
            // 
            this.saveAsTextBox.FormattingEnabled = true;
            this.saveAsTextBox.Items.AddRange(new object[] {
            "Aces",
            "Twos",
            "Threes",
            "Fours",
            "Fives",
            "Sixes",
            "Three of a Kind",
            "Four of a Kind",
            "Full House",
            "Small Straight",
            "Large Straight",
            "Yahtzee",
            "Chance"});
            this.saveAsTextBox.Location = new System.Drawing.Point(172, 359);
            this.saveAsTextBox.Name = "saveAsTextBox";
            this.saveAsTextBox.Size = new System.Drawing.Size(121, 21);
            this.saveAsTextBox.TabIndex = 1;
            // 
            // ScoreLabelAces
            // 
            this.ScoreLabelAces.AutoSize = true;
            this.ScoreLabelAces.Location = new System.Drawing.Point(6, 17);
            this.ScoreLabelAces.Name = "ScoreLabelAces";
            this.ScoreLabelAces.Size = new System.Drawing.Size(31, 13);
            this.ScoreLabelAces.TabIndex = 2;
            this.ScoreLabelAces.Text = "Aces";
            // 
            // ScoreLabelTwos
            // 
            this.ScoreLabelTwos.AutoSize = true;
            this.ScoreLabelTwos.Location = new System.Drawing.Point(6, 39);
            this.ScoreLabelTwos.Name = "ScoreLabelTwos";
            this.ScoreLabelTwos.Size = new System.Drawing.Size(33, 13);
            this.ScoreLabelTwos.TabIndex = 3;
            this.ScoreLabelTwos.Text = "Twos";
            // 
            // ScoreLabelThrees
            // 
            this.ScoreLabelThrees.AutoSize = true;
            this.ScoreLabelThrees.Location = new System.Drawing.Point(5, 61);
            this.ScoreLabelThrees.Name = "ScoreLabelThrees";
            this.ScoreLabelThrees.Size = new System.Drawing.Size(40, 13);
            this.ScoreLabelThrees.TabIndex = 4;
            this.ScoreLabelThrees.Text = "Threes";
            // 
            // ScoreLabelFours
            // 
            this.ScoreLabelFours.AutoSize = true;
            this.ScoreLabelFours.Location = new System.Drawing.Point(6, 83);
            this.ScoreLabelFours.Name = "ScoreLabelFours";
            this.ScoreLabelFours.Size = new System.Drawing.Size(33, 13);
            this.ScoreLabelFours.TabIndex = 5;
            this.ScoreLabelFours.Text = "Fours";
            // 
            // ScoreLabelFives
            // 
            this.ScoreLabelFives.AutoSize = true;
            this.ScoreLabelFives.Location = new System.Drawing.Point(5, 105);
            this.ScoreLabelFives.Name = "ScoreLabelFives";
            this.ScoreLabelFives.Size = new System.Drawing.Size(32, 13);
            this.ScoreLabelFives.TabIndex = 6;
            this.ScoreLabelFives.Text = "Fives";
            // 
            // ScoreLabelSixes
            // 
            this.ScoreLabelSixes.AutoSize = true;
            this.ScoreLabelSixes.Location = new System.Drawing.Point(5, 127);
            this.ScoreLabelSixes.Name = "ScoreLabelSixes";
            this.ScoreLabelSixes.Size = new System.Drawing.Size(32, 13);
            this.ScoreLabelSixes.TabIndex = 7;
            this.ScoreLabelSixes.Text = "Sixes";
            // 
            // ScoreLabelThreeOfAKind
            // 
            this.ScoreLabelThreeOfAKind.AutoSize = true;
            this.ScoreLabelThreeOfAKind.Location = new System.Drawing.Point(6, 17);
            this.ScoreLabelThreeOfAKind.Name = "ScoreLabelThreeOfAKind";
            this.ScoreLabelThreeOfAKind.Size = new System.Drawing.Size(80, 13);
            this.ScoreLabelThreeOfAKind.TabIndex = 8;
            this.ScoreLabelThreeOfAKind.Text = "Three of a Kind";
            // 
            // BoxUpperSection
            // 
            this.BoxUpperSection.Controls.Add(this.scoreSixes);
            this.BoxUpperSection.Controls.Add(this.scoreFives);
            this.BoxUpperSection.Controls.Add(this.scoreFours);
            this.BoxUpperSection.Controls.Add(this.scoreThrees);
            this.BoxUpperSection.Controls.Add(this.scoreTwos);
            this.BoxUpperSection.Controls.Add(this.scoreAces);
            this.BoxUpperSection.Controls.Add(this.ScoreLabelSixes);
            this.BoxUpperSection.Controls.Add(this.ScoreLabelFives);
            this.BoxUpperSection.Controls.Add(this.ScoreLabelFours);
            this.BoxUpperSection.Controls.Add(this.ScoreLabelThrees);
            this.BoxUpperSection.Controls.Add(this.ScoreLabelTwos);
            this.BoxUpperSection.Controls.Add(this.ScoreLabelAces);
            this.BoxUpperSection.Location = new System.Drawing.Point(23, 42);
            this.BoxUpperSection.Name = "BoxUpperSection";
            this.BoxUpperSection.Size = new System.Drawing.Size(157, 173);
            this.BoxUpperSection.TabIndex = 9;
            this.BoxUpperSection.TabStop = false;
            this.BoxUpperSection.Text = "Upper Section";
            // 
            // scoreSixes
            // 
            this.scoreSixes.AutoSize = true;
            this.scoreSixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreSixes.Location = new System.Drawing.Point(87, 127);
            this.scoreSixes.Name = "scoreSixes";
            this.scoreSixes.Size = new System.Drawing.Size(10, 13);
            this.scoreSixes.TabIndex = 13;
            this.scoreSixes.Text = " ";
            // 
            // scoreFives
            // 
            this.scoreFives.AutoSize = true;
            this.scoreFives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreFives.Location = new System.Drawing.Point(87, 105);
            this.scoreFives.Name = "scoreFives";
            this.scoreFives.Size = new System.Drawing.Size(10, 13);
            this.scoreFives.TabIndex = 12;
            this.scoreFives.Text = " ";
            // 
            // scoreFours
            // 
            this.scoreFours.AutoSize = true;
            this.scoreFours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreFours.Location = new System.Drawing.Point(87, 83);
            this.scoreFours.Name = "scoreFours";
            this.scoreFours.Size = new System.Drawing.Size(10, 13);
            this.scoreFours.TabIndex = 11;
            this.scoreFours.Text = " ";
            // 
            // scoreThrees
            // 
            this.scoreThrees.AutoSize = true;
            this.scoreThrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreThrees.Location = new System.Drawing.Point(87, 61);
            this.scoreThrees.Name = "scoreThrees";
            this.scoreThrees.Size = new System.Drawing.Size(10, 13);
            this.scoreThrees.TabIndex = 10;
            this.scoreThrees.Text = " ";
            // 
            // scoreTwos
            // 
            this.scoreTwos.AutoSize = true;
            this.scoreTwos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTwos.Location = new System.Drawing.Point(87, 39);
            this.scoreTwos.Name = "scoreTwos";
            this.scoreTwos.Size = new System.Drawing.Size(10, 13);
            this.scoreTwos.TabIndex = 9;
            this.scoreTwos.Text = " ";
            // 
            // scoreAces
            // 
            this.scoreAces.AutoSize = true;
            this.scoreAces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreAces.Location = new System.Drawing.Point(87, 18);
            this.scoreAces.Name = "scoreAces";
            this.scoreAces.Size = new System.Drawing.Size(10, 13);
            this.scoreAces.TabIndex = 8;
            this.scoreAces.Text = " ";
            // 
            // BoxLowerSection
            // 
            this.BoxLowerSection.Controls.Add(this.chanceScore);
            this.BoxLowerSection.Controls.Add(this.YahtzeeScore);
            this.BoxLowerSection.Controls.Add(this.largeStraightScore);
            this.BoxLowerSection.Controls.Add(this.smallStraightScore);
            this.BoxLowerSection.Controls.Add(this.fullHouseScore);
            this.BoxLowerSection.Controls.Add(this.fourOfAKindScore);
            this.BoxLowerSection.Controls.Add(this.threeOfAKindScore);
            this.BoxLowerSection.Controls.Add(this.ScoreLabelChance);
            this.BoxLowerSection.Controls.Add(this.ScoreLabelYahtzee);
            this.BoxLowerSection.Controls.Add(this.ScoreLabelLargeStraight);
            this.BoxLowerSection.Controls.Add(this.ScoreLabelSmallStraight);
            this.BoxLowerSection.Controls.Add(this.ScoreLableFullHouse);
            this.BoxLowerSection.Controls.Add(this.ScoreLableFourOfAKind);
            this.BoxLowerSection.Controls.Add(this.ScoreLabelThreeOfAKind);
            this.BoxLowerSection.Location = new System.Drawing.Point(230, 42);
            this.BoxLowerSection.Name = "BoxLowerSection";
            this.BoxLowerSection.Size = new System.Drawing.Size(200, 173);
            this.BoxLowerSection.TabIndex = 10;
            this.BoxLowerSection.TabStop = false;
            this.BoxLowerSection.Text = "Lower Section";
            // 
            // chanceScore
            // 
            this.chanceScore.AutoSize = true;
            this.chanceScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceScore.Location = new System.Drawing.Point(131, 149);
            this.chanceScore.Name = "chanceScore";
            this.chanceScore.Size = new System.Drawing.Size(10, 13);
            this.chanceScore.TabIndex = 21;
            this.chanceScore.Text = " ";
            // 
            // YahtzeeScore
            // 
            this.YahtzeeScore.AutoSize = true;
            this.YahtzeeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YahtzeeScore.Location = new System.Drawing.Point(131, 127);
            this.YahtzeeScore.Name = "YahtzeeScore";
            this.YahtzeeScore.Size = new System.Drawing.Size(10, 13);
            this.YahtzeeScore.TabIndex = 20;
            this.YahtzeeScore.Text = " ";
            // 
            // largeStraightScore
            // 
            this.largeStraightScore.AutoSize = true;
            this.largeStraightScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeStraightScore.Location = new System.Drawing.Point(131, 105);
            this.largeStraightScore.Name = "largeStraightScore";
            this.largeStraightScore.Size = new System.Drawing.Size(10, 13);
            this.largeStraightScore.TabIndex = 19;
            this.largeStraightScore.Text = " ";
            // 
            // smallStraightScore
            // 
            this.smallStraightScore.AutoSize = true;
            this.smallStraightScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallStraightScore.Location = new System.Drawing.Point(131, 83);
            this.smallStraightScore.Name = "smallStraightScore";
            this.smallStraightScore.Size = new System.Drawing.Size(10, 13);
            this.smallStraightScore.TabIndex = 18;
            this.smallStraightScore.Text = " ";
            // 
            // fullHouseScore
            // 
            this.fullHouseScore.AutoSize = true;
            this.fullHouseScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullHouseScore.Location = new System.Drawing.Point(131, 61);
            this.fullHouseScore.Name = "fullHouseScore";
            this.fullHouseScore.Size = new System.Drawing.Size(10, 13);
            this.fullHouseScore.TabIndex = 17;
            this.fullHouseScore.Text = " ";
            // 
            // fourOfAKindScore
            // 
            this.fourOfAKindScore.AutoSize = true;
            this.fourOfAKindScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourOfAKindScore.Location = new System.Drawing.Point(131, 39);
            this.fourOfAKindScore.Name = "fourOfAKindScore";
            this.fourOfAKindScore.Size = new System.Drawing.Size(10, 13);
            this.fourOfAKindScore.TabIndex = 16;
            this.fourOfAKindScore.Text = " ";
            // 
            // threeOfAKindScore
            // 
            this.threeOfAKindScore.AutoSize = true;
            this.threeOfAKindScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfAKindScore.Location = new System.Drawing.Point(131, 17);
            this.threeOfAKindScore.Name = "threeOfAKindScore";
            this.threeOfAKindScore.Size = new System.Drawing.Size(10, 13);
            this.threeOfAKindScore.TabIndex = 15;
            this.threeOfAKindScore.Text = " ";
            // 
            // ScoreLabelChance
            // 
            this.ScoreLabelChance.AutoSize = true;
            this.ScoreLabelChance.Location = new System.Drawing.Point(6, 149);
            this.ScoreLabelChance.Name = "ScoreLabelChance";
            this.ScoreLabelChance.Size = new System.Drawing.Size(44, 13);
            this.ScoreLabelChance.TabIndex = 14;
            this.ScoreLabelChance.Text = "Chance";
            // 
            // ScoreLabelYahtzee
            // 
            this.ScoreLabelYahtzee.AutoSize = true;
            this.ScoreLabelYahtzee.Location = new System.Drawing.Point(6, 127);
            this.ScoreLabelYahtzee.Name = "ScoreLabelYahtzee";
            this.ScoreLabelYahtzee.Size = new System.Drawing.Size(46, 13);
            this.ScoreLabelYahtzee.TabIndex = 13;
            this.ScoreLabelYahtzee.Text = "Yahtzee";
            // 
            // ScoreLabelLargeStraight
            // 
            this.ScoreLabelLargeStraight.AutoSize = true;
            this.ScoreLabelLargeStraight.Location = new System.Drawing.Point(6, 105);
            this.ScoreLabelLargeStraight.Name = "ScoreLabelLargeStraight";
            this.ScoreLabelLargeStraight.Size = new System.Drawing.Size(73, 13);
            this.ScoreLabelLargeStraight.TabIndex = 12;
            this.ScoreLabelLargeStraight.Text = "Large Straight";
            // 
            // ScoreLabelSmallStraight
            // 
            this.ScoreLabelSmallStraight.AutoSize = true;
            this.ScoreLabelSmallStraight.Location = new System.Drawing.Point(6, 83);
            this.ScoreLabelSmallStraight.Name = "ScoreLabelSmallStraight";
            this.ScoreLabelSmallStraight.Size = new System.Drawing.Size(71, 13);
            this.ScoreLabelSmallStraight.TabIndex = 11;
            this.ScoreLabelSmallStraight.Text = "Small Straight";
            // 
            // ScoreLableFullHouse
            // 
            this.ScoreLableFullHouse.AutoSize = true;
            this.ScoreLableFullHouse.Location = new System.Drawing.Point(6, 61);
            this.ScoreLableFullHouse.Name = "ScoreLableFullHouse";
            this.ScoreLableFullHouse.Size = new System.Drawing.Size(57, 13);
            this.ScoreLableFullHouse.TabIndex = 10;
            this.ScoreLableFullHouse.Text = "Full House";
            // 
            // ScoreLableFourOfAKind
            // 
            this.ScoreLableFourOfAKind.AutoSize = true;
            this.ScoreLableFourOfAKind.Location = new System.Drawing.Point(6, 39);
            this.ScoreLableFourOfAKind.Name = "ScoreLableFourOfAKind";
            this.ScoreLableFourOfAKind.Size = new System.Drawing.Size(73, 13);
            this.ScoreLableFourOfAKind.TabIndex = 9;
            this.ScoreLableFourOfAKind.Text = "Four of a Kind";
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(321, 358);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 11;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // diceBox
            // 
            this.diceBox.Controls.Add(this.dieFive);
            this.diceBox.Controls.Add(this.dieFour);
            this.diceBox.Controls.Add(this.dieThree);
            this.diceBox.Controls.Add(this.dieTwo);
            this.diceBox.Controls.Add(this.dieOne);
            this.diceBox.Location = new System.Drawing.Point(70, 232);
            this.diceBox.Name = "diceBox";
            this.diceBox.Size = new System.Drawing.Size(308, 98);
            this.diceBox.TabIndex = 12;
            this.diceBox.TabStop = false;
            this.diceBox.Text = "Dice";
            // 
            // dieFive
            // 
            this.dieFive.AutoSize = true;
            this.dieFive.Location = new System.Drawing.Point(251, 49);
            this.dieFive.Name = "dieFive";
            this.dieFive.Size = new System.Drawing.Size(13, 13);
            this.dieFive.TabIndex = 4;
            this.dieFive.Text = "5";
            this.dieFive.Click += new System.EventHandler(this.dieFive_Click);
            // 
            // dieFour
            // 
            this.dieFour.AutoSize = true;
            this.dieFour.Location = new System.Drawing.Point(196, 47);
            this.dieFour.Name = "dieFour";
            this.dieFour.Size = new System.Drawing.Size(13, 13);
            this.dieFour.TabIndex = 3;
            this.dieFour.Text = "4";
            this.dieFour.Click += new System.EventHandler(this.dieFour_Click);
            // 
            // dieThree
            // 
            this.dieThree.AutoSize = true;
            this.dieThree.Location = new System.Drawing.Point(136, 49);
            this.dieThree.Name = "dieThree";
            this.dieThree.Size = new System.Drawing.Size(13, 13);
            this.dieThree.TabIndex = 2;
            this.dieThree.Text = "3";
            this.dieThree.Click += new System.EventHandler(this.dieThree_Click);
            // 
            // dieTwo
            // 
            this.dieTwo.AutoSize = true;
            this.dieTwo.Location = new System.Drawing.Point(80, 48);
            this.dieTwo.Name = "dieTwo";
            this.dieTwo.Size = new System.Drawing.Size(13, 13);
            this.dieTwo.TabIndex = 1;
            this.dieTwo.Text = "2";
            this.dieTwo.Click += new System.EventHandler(this.dieTwo_Click);
            // 
            // dieOne
            // 
            this.dieOne.AutoSize = true;
            this.dieOne.Location = new System.Drawing.Point(22, 47);
            this.dieOne.Name = "dieOne";
            this.dieOne.Size = new System.Drawing.Size(13, 13);
            this.dieOne.TabIndex = 0;
            this.dieOne.Text = "1";
            this.dieOne.Click += new System.EventHandler(this.dieOne_Click);
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.AutoSize = true;
            this.finalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLabel.Location = new System.Drawing.Point(92, 9);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(93, 20);
            this.finalScoreLabel.TabIndex = 13;
            this.finalScoreLabel.Text = "Final Score:";
            // 
            // finalScore
            // 
            this.finalScore.AutoSize = true;
            this.finalScore.Location = new System.Drawing.Point(191, 14);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(13, 13);
            this.finalScore.TabIndex = 14;
            this.finalScore.Text = "0";
            // 
            // yahtzeeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 392);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.diceBox);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.BoxLowerSection);
            this.Controls.Add(this.BoxUpperSection);
            this.Controls.Add(this.saveAsTextBox);
            this.Controls.Add(this.ButtonRoll);
            this.Name = "yahtzeeGame";
            this.Text = "Yahtzee";
            this.BoxUpperSection.ResumeLayout(false);
            this.BoxUpperSection.PerformLayout();
            this.BoxLowerSection.ResumeLayout(false);
            this.BoxLowerSection.PerformLayout();
            this.diceBox.ResumeLayout(false);
            this.diceBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRoll;
        private System.Windows.Forms.ComboBox saveAsTextBox;
        private System.Windows.Forms.Label ScoreLabelAces;
        private System.Windows.Forms.Label ScoreLabelTwos;
        private System.Windows.Forms.Label ScoreLabelThrees;
        private System.Windows.Forms.Label ScoreLabelFours;
        private System.Windows.Forms.Label ScoreLabelFives;
        private System.Windows.Forms.Label ScoreLabelSixes;
        private System.Windows.Forms.Label ScoreLabelThreeOfAKind;
        private System.Windows.Forms.GroupBox BoxUpperSection;
        private System.Windows.Forms.GroupBox BoxLowerSection;
        private System.Windows.Forms.Label ScoreLabelChance;
        private System.Windows.Forms.Label ScoreLabelYahtzee;
        private System.Windows.Forms.Label ScoreLabelLargeStraight;
        private System.Windows.Forms.Label ScoreLabelSmallStraight;
        private System.Windows.Forms.Label ScoreLableFullHouse;
        private System.Windows.Forms.Label ScoreLableFourOfAKind;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.GroupBox diceBox;
        private System.Windows.Forms.Label dieFive;
        private System.Windows.Forms.Label dieFour;
        private System.Windows.Forms.Label dieThree;
        private System.Windows.Forms.Label dieTwo;
        private System.Windows.Forms.Label dieOne;
        private System.Windows.Forms.Label scoreSixes;
        private System.Windows.Forms.Label scoreFives;
        private System.Windows.Forms.Label scoreFours;
        private System.Windows.Forms.Label scoreThrees;
        private System.Windows.Forms.Label scoreTwos;
        private System.Windows.Forms.Label scoreAces;
        private System.Windows.Forms.Label chanceScore;
        private System.Windows.Forms.Label YahtzeeScore;
        private System.Windows.Forms.Label largeStraightScore;
        private System.Windows.Forms.Label smallStraightScore;
        private System.Windows.Forms.Label fullHouseScore;
        private System.Windows.Forms.Label fourOfAKindScore;
        private System.Windows.Forms.Label threeOfAKindScore;
        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.Label finalScore;
    }
}

