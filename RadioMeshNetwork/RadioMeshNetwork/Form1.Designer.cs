﻿namespace RadioMeshNetwork
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.MessagesListBox = new System.Windows.Forms.ListBox();
            this.AvaialbleRadiosCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ConfirmationTextbox = new System.Windows.Forms.TextBox();
            this.TypeMessageTextbox = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.fetchRadiosButton = new System.Windows.Forms.Button();
            this.NetworkUpdateButton = new System.Windows.Forms.Button();
            this.COMPortsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MessagesListBox
            // 
            this.MessagesListBox.FormattingEnabled = true;
            this.MessagesListBox.Location = new System.Drawing.Point(270, 12);
            this.MessagesListBox.Name = "MessagesListBox";
            this.MessagesListBox.Size = new System.Drawing.Size(318, 368);
            this.MessagesListBox.TabIndex = 0;
            // 
            // AvaialbleRadiosCheckedListBox
            // 
            this.AvaialbleRadiosCheckedListBox.FormattingEnabled = true;
            this.AvaialbleRadiosCheckedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AvaialbleRadiosCheckedListBox.Location = new System.Drawing.Point(13, 12);
            this.AvaialbleRadiosCheckedListBox.Name = "AvaialbleRadiosCheckedListBox";
            this.AvaialbleRadiosCheckedListBox.Size = new System.Drawing.Size(251, 139);
            this.AvaialbleRadiosCheckedListBox.TabIndex = 1;
            // 
            // ConfirmationTextbox
            // 
            this.ConfirmationTextbox.Location = new System.Drawing.Point(13, 337);
            this.ConfirmationTextbox.Multiline = true;
            this.ConfirmationTextbox.Name = "ConfirmationTextbox";
            this.ConfirmationTextbox.ReadOnly = true;
            this.ConfirmationTextbox.Size = new System.Drawing.Size(251, 44);
            this.ConfirmationTextbox.TabIndex = 2;
            this.ConfirmationTextbox.Text = "Current Status: Unconnected";
            // 
            // TypeMessageTextbox
            // 
            this.TypeMessageTextbox.Location = new System.Drawing.Point(270, 387);
            this.TypeMessageTextbox.Multiline = true;
            this.TypeMessageTextbox.Name = "TypeMessageTextbox";
            this.TypeMessageTextbox.Size = new System.Drawing.Size(318, 68);
            this.TypeMessageTextbox.TabIndex = 4;
            this.TypeMessageTextbox.Text = "Type your message here...";
            this.TypeMessageTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypeMessageTextbox_KeyDown);
            // 
            // serialPort
            // 
            this.serialPort.ReadTimeout = 10000;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Enabled = false;
            this.SendMessageButton.Location = new System.Drawing.Point(270, 461);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(318, 50);
            this.SendMessageButton.TabIndex = 5;
            this.SendMessageButton.Text = "Click here to send your message!";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(13, 387);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(251, 37);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect to Radio";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // fetchRadiosButton
            // 
            this.fetchRadiosButton.Enabled = false;
            this.fetchRadiosButton.Location = new System.Drawing.Point(13, 431);
            this.fetchRadiosButton.Name = "fetchRadiosButton";
            this.fetchRadiosButton.Size = new System.Drawing.Size(112, 37);
            this.fetchRadiosButton.TabIndex = 7;
            this.fetchRadiosButton.Text = "Fetch Radios";
            this.fetchRadiosButton.UseVisualStyleBackColor = true;
            this.fetchRadiosButton.Click += new System.EventHandler(this.fetchRadiosButton_Click);
            // 
            // NetworkUpdateButton
            // 
            this.NetworkUpdateButton.Enabled = false;
            this.NetworkUpdateButton.Location = new System.Drawing.Point(13, 474);
            this.NetworkUpdateButton.Name = "NetworkUpdateButton";
            this.NetworkUpdateButton.Size = new System.Drawing.Size(251, 37);
            this.NetworkUpdateButton.TabIndex = 8;
            this.NetworkUpdateButton.Text = "Network Update";
            this.NetworkUpdateButton.UseVisualStyleBackColor = true;
            this.NetworkUpdateButton.Click += new System.EventHandler(this.NetworkUpdateButton_Click);
            // 
            // COMPortsCheckedListBox
            // 
            this.COMPortsCheckedListBox.FormattingEnabled = true;
            this.COMPortsCheckedListBox.Location = new System.Drawing.Point(13, 158);
            this.COMPortsCheckedListBox.Name = "COMPortsCheckedListBox";
            this.COMPortsCheckedListBox.Size = new System.Drawing.Size(250, 169);
            this.COMPortsCheckedListBox.TabIndex = 9;
            // 
            // RestartButton
            // 
            this.RestartButton.Enabled = false;
            this.RestartButton.Location = new System.Drawing.Point(158, 431);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(105, 37);
            this.RestartButton.TabIndex = 10;
            this.RestartButton.Text = "Restart Radio";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 517);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 552);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.COMPortsCheckedListBox);
            this.Controls.Add(this.NetworkUpdateButton);
            this.Controls.Add(this.fetchRadiosButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.TypeMessageTextbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ConfirmationTextbox);
            this.Controls.Add(this.AvaialbleRadiosCheckedListBox);
            this.Controls.Add(this.MessagesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessagesListBox;
        private System.Windows.Forms.CheckedListBox AvaialbleRadiosCheckedListBox;
        private System.Windows.Forms.TextBox ConfirmationTextbox;
        private System.Windows.Forms.TextBox TypeMessageTextbox;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button fetchRadiosButton;
        private System.Windows.Forms.Button NetworkUpdateButton;
        private System.Windows.Forms.CheckedListBox COMPortsCheckedListBox;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

