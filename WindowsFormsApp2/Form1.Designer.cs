namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.next = new System.Windows.Forms.Button();
            this.candidate = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThisAward = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.lucker = new System.Windows.Forms.Label();
            this.remainlucker = new System.Windows.Forms.Label();
            this.thiawardremain = new System.Windows.Forms.Label();
            this.autogen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allowmulti = new System.Windows.Forms.CheckBox();
            this.autogentimer = new System.Windows.Forms.Timer(this.components);
            this.showname = new System.Windows.Forms.Timer(this.components);
            this.awardinfo = new System.Windows.Forms.Label();
            this.calllucker = new System.Windows.Forms.CheckBox();
            this.autonext = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 235);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(604, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.next.Location = new System.Drawing.Point(278, 290);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(251, 84);
            this.next.TabIndex = 0;
            this.next.Text = "開始抽獎";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // candidate
            // 
            this.candidate.Font = new System.Drawing.Font("宋体", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.candidate.Location = new System.Drawing.Point(175, 121);
            this.candidate.Name = "candidate";
            this.candidate.Size = new System.Drawing.Size(450, 97);
            this.candidate.TabIndex = 2;
            this.candidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(767, 401);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 3;
            this.log.Text = "中獎記錄";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "縂人數:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "已抽獎:";
            // 
            // ThisAward
            // 
            this.ThisAward.AutoSize = true;
            this.ThisAward.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThisAward.Location = new System.Drawing.Point(680, 233);
            this.ThisAward.Name = "ThisAward";
            this.ThisAward.Size = new System.Drawing.Size(143, 33);
            this.ThisAward.TabIndex = 6;
            this.ThisAward.Text = "獎項名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "剩餘獎數:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(76, 13);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(11, 12);
            this.total.TabIndex = 8;
            this.total.Text = "0";
            // 
            // lucker
            // 
            this.lucker.AutoSize = true;
            this.lucker.Location = new System.Drawing.Point(76, 32);
            this.lucker.Name = "lucker";
            this.lucker.Size = new System.Drawing.Size(11, 12);
            this.lucker.TabIndex = 8;
            this.lucker.Text = "0";
            // 
            // remainlucker
            // 
            this.remainlucker.AutoSize = true;
            this.remainlucker.Location = new System.Drawing.Point(76, 53);
            this.remainlucker.Name = "remainlucker";
            this.remainlucker.Size = new System.Drawing.Size(11, 12);
            this.remainlucker.TabIndex = 8;
            this.remainlucker.Text = "0";
            // 
            // thiawardremain
            // 
            this.thiawardremain.AutoSize = true;
            this.thiawardremain.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thiawardremain.Location = new System.Drawing.Point(563, 316);
            this.thiawardremain.Name = "thiawardremain";
            this.thiawardremain.Size = new System.Drawing.Size(79, 33);
            this.thiawardremain.TabIndex = 6;
            this.thiawardremain.Text = "剩餘";
            // 
            // autogen
            // 
            this.autogen.FormattingEnabled = true;
            this.autogen.Items.AddRange(new object[] {
            "1秒后",
            "3秒后",
            "10秒后",
            "關閉"});
            this.autogen.Location = new System.Drawing.Point(13, 73);
            this.autogen.Name = "autogen";
            this.autogen.Size = new System.Drawing.Size(74, 20);
            this.autogen.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "自動出獎";
            // 
            // allowmulti
            // 
            this.allowmulti.AutoSize = true;
            this.allowmulti.Location = new System.Drawing.Point(12, 121);
            this.allowmulti.Name = "allowmulti";
            this.allowmulti.Size = new System.Drawing.Size(84, 16);
            this.allowmulti.TabIndex = 10;
            this.allowmulti.Text = "允許中多次";
            this.allowmulti.UseVisualStyleBackColor = true;
            // 
            // autogentimer
            // 
            this.autogentimer.Interval = 1000;
            this.autogentimer.Tick += new System.EventHandler(this.autogentimer_Tick);
            // 
            // showname
            // 
            this.showname.Interval = 5;
            this.showname.Tick += new System.EventHandler(this.showname_Tick);
            // 
            // awardinfo
            // 
            this.awardinfo.AutoSize = true;
            this.awardinfo.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.awardinfo.Location = new System.Drawing.Point(648, 319);
            this.awardinfo.Name = "awardinfo";
            this.awardinfo.Size = new System.Drawing.Size(28, 29);
            this.awardinfo.TabIndex = 8;
            this.awardinfo.Text = "0";
            // 
            // calllucker
            // 
            this.calllucker.AutoSize = true;
            this.calllucker.Location = new System.Drawing.Point(12, 140);
            this.calllucker.Name = "calllucker";
            this.calllucker.Size = new System.Drawing.Size(108, 16);
            this.calllucker.TabIndex = 11;
            this.calllucker.Text = "自動呼叫幸運兒";
            this.calllucker.UseVisualStyleBackColor = true;
            this.calllucker.Visible = false;
            // 
            // autonext
            // 
            this.autonext.AutoSize = true;
            this.autonext.Location = new System.Drawing.Point(12, 99);
            this.autonext.Name = "autonext";
            this.autonext.Size = new System.Drawing.Size(108, 16);
            this.autonext.TabIndex = 11;
            this.autonext.Text = "自動抽出下一位";
            this.autonext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.autonext);
            this.Controls.Add(this.calllucker);
            this.Controls.Add(this.allowmulti);
            this.Controls.Add(this.autogen);
            this.Controls.Add(this.awardinfo);
            this.Controls.Add(this.remainlucker);
            this.Controls.Add(this.lucker);
            this.Controls.Add(this.total);
            this.Controls.Add(this.thiawardremain);
            this.Controls.Add(this.ThisAward);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.candidate);
            this.Controls.Add(this.next);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽獎啦！！！！";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Label candidate;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ThisAward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label lucker;
        private System.Windows.Forms.Label remainlucker;
        private System.Windows.Forms.Label thiawardremain;
        private System.Windows.Forms.ComboBox autogen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox allowmulti;
        private System.Windows.Forms.Timer autogentimer;
        private System.Windows.Forms.Timer showname;
        private System.Windows.Forms.Label awardinfo;
        private System.Windows.Forms.CheckBox calllucker;
        private System.Windows.Forms.CheckBox autonext;
    }
}

