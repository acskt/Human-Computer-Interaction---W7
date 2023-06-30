<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        IconMenuItem1 = New FontAwesome.Sharp.IconMenuItem()
        PanelMenu = New Panel()
        btnSetting = New FontAwesome.Sharp.IconButton()
        btnMarketing = New FontAwesome.Sharp.IconButton()
        btnCustomers = New FontAwesome.Sharp.IconButton()
        btnProducts = New FontAwesome.Sharp.IconButton()
        btnOrders = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        Label1 = New Label()
        IconHome = New FontAwesome.Sharp.IconPictureBox()
        PanelTitleBar = New Panel()
        IconClose = New FontAwesome.Sharp.IconPictureBox()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PanelMenu.SuspendLayout()
        Panel2.SuspendLayout()
        CType(IconHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        CType(IconClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconMenuItem1
        ' 
        IconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None
        IconMenuItem1.IconColor = Color.Black
        IconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconMenuItem1.Name = "IconMenuItem1"
        IconMenuItem1.Size = New Size(32, 19)
        IconMenuItem1.Text = "IconMenuItem1"
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(75), CByte(101), CByte(132))
        PanelMenu.Controls.Add(btnSetting)
        PanelMenu.Controls.Add(btnMarketing)
        PanelMenu.Controls.Add(btnCustomers)
        PanelMenu.Controls.Add(btnProducts)
        PanelMenu.Controls.Add(btnOrders)
        PanelMenu.Controls.Add(btnDashboard)
        PanelMenu.Controls.Add(Panel2)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(200, 564)
        PanelMenu.TabIndex = 0
        ' 
        ' btnSetting
        ' 
        btnSetting.Dock = DockStyle.Top
        btnSetting.FlatAppearance.BorderSize = 0
        btnSetting.FlatStyle = FlatStyle.Flat
        btnSetting.ForeColor = SystemColors.ControlLightLight
        btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear
        btnSetting.IconColor = Color.WhiteSmoke
        btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSetting.ImageAlign = ContentAlignment.MiddleLeft
        btnSetting.Location = New Point(0, 400)
        btnSetting.Name = "btnSetting"
        btnSetting.Padding = New Padding(10, 0, 0, 0)
        btnSetting.Size = New Size(200, 60)
        btnSetting.TabIndex = 6
        btnSetting.Text = "Setting"
        btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSetting.UseVisualStyleBackColor = True
        ' 
        ' btnMarketing
        ' 
        btnMarketing.Dock = DockStyle.Top
        btnMarketing.FlatAppearance.BorderSize = 0
        btnMarketing.FlatStyle = FlatStyle.Flat
        btnMarketing.ForeColor = SystemColors.ControlLightLight
        btnMarketing.IconChar = FontAwesome.Sharp.IconChar.Ad
        btnMarketing.IconColor = Color.WhiteSmoke
        btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMarketing.ImageAlign = ContentAlignment.MiddleLeft
        btnMarketing.Location = New Point(0, 340)
        btnMarketing.Name = "btnMarketing"
        btnMarketing.Padding = New Padding(10, 0, 0, 0)
        btnMarketing.Size = New Size(200, 60)
        btnMarketing.TabIndex = 5
        btnMarketing.Text = "Marketing"
        btnMarketing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMarketing.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Dock = DockStyle.Top
        btnCustomers.FlatAppearance.BorderSize = 0
        btnCustomers.FlatStyle = FlatStyle.Flat
        btnCustomers.ForeColor = SystemColors.ControlLightLight
        btnCustomers.IconChar = FontAwesome.Sharp.IconChar.PeopleArrowsLeftRight
        btnCustomers.IconColor = Color.WhiteSmoke
        btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCustomers.ImageAlign = ContentAlignment.MiddleLeft
        btnCustomers.Location = New Point(0, 280)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Padding = New Padding(10, 0, 0, 0)
        btnCustomers.Size = New Size(200, 60)
        btnCustomers.TabIndex = 4
        btnCustomers.Text = "Customers"
        btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Dock = DockStyle.Top
        btnProducts.FlatAppearance.BorderSize = 0
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.ForeColor = SystemColors.ControlLightLight
        btnProducts.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        btnProducts.IconColor = Color.WhiteSmoke
        btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft
        btnProducts.Location = New Point(0, 220)
        btnProducts.Name = "btnProducts"
        btnProducts.Padding = New Padding(10, 0, 0, 0)
        btnProducts.Size = New Size(200, 60)
        btnProducts.TabIndex = 3
        btnProducts.Text = "Products"
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.Dock = DockStyle.Top
        btnOrders.FlatAppearance.BorderSize = 0
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.ForeColor = SystemColors.ControlLightLight
        btnOrders.IconChar = FontAwesome.Sharp.IconChar.TruckFront
        btnOrders.IconColor = Color.WhiteSmoke
        btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft
        btnOrders.Location = New Point(0, 160)
        btnOrders.Name = "btnOrders"
        btnOrders.Padding = New Padding(10, 0, 0, 0)
        btnOrders.Size = New Size(200, 60)
        btnOrders.TabIndex = 2
        btnOrders.Text = "Orders"
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = SystemColors.ControlLightLight
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple
        btnDashboard.IconColor = Color.WhiteSmoke
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 100)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 0, 0)
        btnDashboard.Size = New Size(200, 60)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(IconHome)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(15), CByte(185), CByte(177))
        Label1.Location = New Point(93, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 42)
        Label1.TabIndex = 1
        Label1.Text = "Ghost" & vbCrLf & "Order" & vbCrLf & "System"
        ' 
        ' IconHome
        ' 
        IconHome.BackColor = Color.Transparent
        IconHome.ForeColor = Color.FromArgb(CByte(15), CByte(185), CByte(177))
        IconHome.IconChar = FontAwesome.Sharp.IconChar.Ghost
        IconHome.IconColor = Color.FromArgb(CByte(15), CByte(185), CByte(177))
        IconHome.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconHome.IconSize = 60
        IconHome.Location = New Point(41, 20)
        IconHome.Name = "IconHome"
        IconHome.Size = New Size(110, 60)
        IconHome.TabIndex = 0
        IconHome.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.FromArgb(CByte(75), CByte(101), CByte(132))
        PanelTitleBar.Controls.Add(IconClose)
        PanelTitleBar.Controls.Add(lblFormTitle)
        PanelTitleBar.Controls.Add(IconCurrentForm)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(200, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(916, 70)
        PanelTitleBar.TabIndex = 1
        ' 
        ' IconClose
        ' 
        IconClose.Anchor = AnchorStyles.Right
        IconClose.BackColor = Color.FromArgb(CByte(75), CByte(101), CByte(132))
        IconClose.IconChar = FontAwesome.Sharp.IconChar.X
        IconClose.IconColor = Color.White
        IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconClose.IconSize = 24
        IconClose.Location = New Point(888, 4)
        IconClose.Name = "IconClose"
        IconClose.Size = New Size(28, 24)
        IconClose.TabIndex = 1
        IconClose.TabStop = False
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(81, 27)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(42, 14)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(75), CByte(101), CByte(132))
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser
        IconCurrentForm.IconColor = Color.White
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.IconSize = 63
        IconCurrentForm.Location = New Point(6, 4)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(69, 63)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(117), CByte(159), CByte(208))
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(200, 70)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(916, 494)
        PanelDesktop.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1116, 564)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        Name = "Form1"
        Text = "Form1"
        PanelMenu.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconHome, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        CType(IconClose, ComponentModel.ISupportInitialize).EndInit()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents IconMenuItem1 As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOrders As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMarketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents IconHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconClose As FontAwesome.Sharp.IconPictureBox
End Class
