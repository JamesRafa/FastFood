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
        Label1 = New Label()
        lblBurger = New Label()
        lblFries = New Label()
        lblHotdog = New Label()
        lblYumburger = New Label()
        btnBurgerMinus = New Button()
        btnBurgerPlus = New Button()
        txtBurger = New TextBox()
        txtFries = New TextBox()
        btnFriesPlus = New Button()
        btnFriesMinus = New Button()
        txtHotdog = New TextBox()
        btnHotdogPlus = New Button()
        btnHotdogMinus = New Button()
        txtYumburger = New TextBox()
        btnYumburgerPlus = New Button()
        btnYumburgerMinus = New Button()
        txtClear = New Button()
        btnPlaceOrder = New Button()
        btnReceipt = New Button()
        lblTotal = New Label()
        txtTotal = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(101, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 36)
        Label1.TabIndex = 0
        Label1.Text = "RAFAEL'S FAST FOOD"
        ' 
        ' lblBurger
        ' 
        lblBurger.AutoSize = True
        lblBurger.BackColor = Color.Transparent
        lblBurger.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBurger.Location = New Point(79, 115)
        lblBurger.Name = "lblBurger"
        lblBurger.Size = New Size(79, 20)
        lblBurger.TabIndex = 1
        lblBurger.Text = "BURGER"
        ' 
        ' lblFries
        ' 
        lblFries.AutoSize = True
        lblFries.BackColor = Color.Transparent
        lblFries.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFries.Location = New Point(321, 115)
        lblFries.Name = "lblFries"
        lblFries.Size = New Size(58, 20)
        lblFries.TabIndex = 2
        lblFries.Text = "FRIES"
        ' 
        ' lblHotdog
        ' 
        lblHotdog.AutoSize = True
        lblHotdog.BackColor = Color.Transparent
        lblHotdog.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHotdog.Location = New Point(74, 206)
        lblHotdog.Name = "lblHotdog"
        lblHotdog.Size = New Size(84, 20)
        lblHotdog.TabIndex = 3
        lblHotdog.Text = "HOTDOG"
        ' 
        ' lblYumburger
        ' 
        lblYumburger.AutoSize = True
        lblYumburger.BackColor = Color.Transparent
        lblYumburger.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblYumburger.Location = New Point(300, 206)
        lblYumburger.Name = "lblYumburger"
        lblYumburger.Size = New Size(120, 20)
        lblYumburger.TabIndex = 4
        lblYumburger.Text = "YUMBURGER"
        ' 
        ' btnBurgerMinus
        ' 
        btnBurgerMinus.BackColor = SystemColors.ActiveCaption
        btnBurgerMinus.BackgroundImageLayout = ImageLayout.None
        btnBurgerMinus.ForeColor = SystemColors.ControlText
        btnBurgerMinus.Location = New Point(49, 151)
        btnBurgerMinus.Name = "btnBurgerMinus"
        btnBurgerMinus.Size = New Size(28, 25)
        btnBurgerMinus.TabIndex = 5
        btnBurgerMinus.Text = "-"
        btnBurgerMinus.UseVisualStyleBackColor = False
        ' 
        ' btnBurgerPlus
        ' 
        btnBurgerPlus.BackColor = SystemColors.ActiveCaption
        btnBurgerPlus.BackgroundImageLayout = ImageLayout.None
        btnBurgerPlus.ForeColor = SystemColors.ControlText
        btnBurgerPlus.Location = New Point(164, 151)
        btnBurgerPlus.Name = "btnBurgerPlus"
        btnBurgerPlus.Size = New Size(28, 25)
        btnBurgerPlus.TabIndex = 6
        btnBurgerPlus.Text = "+"
        btnBurgerPlus.UseVisualStyleBackColor = False
        ' 
        ' txtBurger
        ' 
        txtBurger.Font = New Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBurger.Location = New Point(83, 151)
        txtBurger.Multiline = True
        txtBurger.Name = "txtBurger"
        txtBurger.Size = New Size(75, 25)
        txtBurger.TabIndex = 7
        txtBurger.Text = "0"
        txtBurger.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFries
        ' 
        txtFries.Font = New Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFries.Location = New Point(321, 151)
        txtFries.Multiline = True
        txtFries.Name = "txtFries"
        txtFries.Size = New Size(75, 25)
        txtFries.TabIndex = 10
        txtFries.Text = "0"
        txtFries.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnFriesPlus
        ' 
        btnFriesPlus.BackColor = SystemColors.ActiveCaption
        btnFriesPlus.BackgroundImageLayout = ImageLayout.None
        btnFriesPlus.ForeColor = SystemColors.ControlText
        btnFriesPlus.Location = New Point(402, 151)
        btnFriesPlus.Name = "btnFriesPlus"
        btnFriesPlus.Size = New Size(28, 25)
        btnFriesPlus.TabIndex = 9
        btnFriesPlus.Text = "+"
        btnFriesPlus.UseVisualStyleBackColor = False
        ' 
        ' btnFriesMinus
        ' 
        btnFriesMinus.BackColor = SystemColors.ActiveCaption
        btnFriesMinus.BackgroundImageLayout = ImageLayout.None
        btnFriesMinus.ForeColor = SystemColors.ControlText
        btnFriesMinus.Location = New Point(287, 151)
        btnFriesMinus.Name = "btnFriesMinus"
        btnFriesMinus.Size = New Size(28, 25)
        btnFriesMinus.TabIndex = 8
        btnFriesMinus.Text = "-"
        btnFriesMinus.UseVisualStyleBackColor = False
        ' 
        ' txtHotdog
        ' 
        txtHotdog.Font = New Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHotdog.Location = New Point(87, 244)
        txtHotdog.Multiline = True
        txtHotdog.Name = "txtHotdog"
        txtHotdog.Size = New Size(75, 25)
        txtHotdog.TabIndex = 13
        txtHotdog.Text = "0"
        txtHotdog.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnHotdogPlus
        ' 
        btnHotdogPlus.BackColor = SystemColors.ActiveCaption
        btnHotdogPlus.BackgroundImageLayout = ImageLayout.None
        btnHotdogPlus.ForeColor = SystemColors.ControlText
        btnHotdogPlus.Location = New Point(168, 244)
        btnHotdogPlus.Name = "btnHotdogPlus"
        btnHotdogPlus.Size = New Size(28, 25)
        btnHotdogPlus.TabIndex = 12
        btnHotdogPlus.Text = "+"
        btnHotdogPlus.UseVisualStyleBackColor = False
        ' 
        ' btnHotdogMinus
        ' 
        btnHotdogMinus.BackColor = SystemColors.ActiveCaption
        btnHotdogMinus.BackgroundImageLayout = ImageLayout.None
        btnHotdogMinus.ForeColor = SystemColors.ControlText
        btnHotdogMinus.Location = New Point(53, 244)
        btnHotdogMinus.Name = "btnHotdogMinus"
        btnHotdogMinus.Size = New Size(28, 25)
        btnHotdogMinus.TabIndex = 11
        btnHotdogMinus.Text = "-"
        btnHotdogMinus.UseVisualStyleBackColor = False
        ' 
        ' txtYumburger
        ' 
        txtYumburger.Font = New Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtYumburger.Location = New Point(321, 244)
        txtYumburger.Multiline = True
        txtYumburger.Name = "txtYumburger"
        txtYumburger.Size = New Size(75, 25)
        txtYumburger.TabIndex = 16
        txtYumburger.Text = "0"
        txtYumburger.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnYumburgerPlus
        ' 
        btnYumburgerPlus.BackColor = SystemColors.ActiveCaption
        btnYumburgerPlus.BackgroundImageLayout = ImageLayout.None
        btnYumburgerPlus.ForeColor = SystemColors.ControlText
        btnYumburgerPlus.Location = New Point(402, 244)
        btnYumburgerPlus.Name = "btnYumburgerPlus"
        btnYumburgerPlus.Size = New Size(28, 25)
        btnYumburgerPlus.TabIndex = 15
        btnYumburgerPlus.Text = "+"
        btnYumburgerPlus.UseVisualStyleBackColor = False
        ' 
        ' btnYumburgerMinus
        ' 
        btnYumburgerMinus.BackColor = SystemColors.ActiveCaption
        btnYumburgerMinus.BackgroundImageLayout = ImageLayout.None
        btnYumburgerMinus.ForeColor = SystemColors.ControlText
        btnYumburgerMinus.Location = New Point(287, 244)
        btnYumburgerMinus.Name = "btnYumburgerMinus"
        btnYumburgerMinus.Size = New Size(28, 25)
        btnYumburgerMinus.TabIndex = 14
        btnYumburgerMinus.Text = "-"
        btnYumburgerMinus.UseVisualStyleBackColor = False
        ' 
        ' txtClear
        ' 
        txtClear.BackColor = SystemColors.ActiveBorder
        txtClear.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtClear.Location = New Point(65, 302)
        txtClear.Name = "txtClear"
        txtClear.Size = New Size(75, 40)
        txtClear.TabIndex = 17
        txtClear.Text = "CLEAR FORM"
        txtClear.UseVisualStyleBackColor = False
        ' 
        ' btnPlaceOrder
        ' 
        btnPlaceOrder.BackColor = SystemColors.ActiveBorder
        btnPlaceOrder.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPlaceOrder.Location = New Point(201, 302)
        btnPlaceOrder.Name = "btnPlaceOrder"
        btnPlaceOrder.Size = New Size(75, 40)
        btnPlaceOrder.TabIndex = 18
        btnPlaceOrder.Text = "PLACE ORDER"
        btnPlaceOrder.UseVisualStyleBackColor = False
        ' 
        ' btnReceipt
        ' 
        btnReceipt.BackColor = SystemColors.ActiveBorder
        btnReceipt.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReceipt.Location = New Point(365, 333)
        btnReceipt.Name = "btnReceipt"
        btnReceipt.Size = New Size(75, 40)
        btnReceipt.TabIndex = 19
        btnReceipt.Text = "RECEIPT"
        btnReceipt.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(101, 390)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(64, 20)
        lblTotal.TabIndex = 20
        lblTotal.Text = "TOTAL"
        ' 
        ' txtTotal
        ' 
        txtTotal.Enabled = False
        txtTotal.Font = New Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.Location = New Point(201, 390)
        txtTotal.Multiline = True
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(75, 25)
        txtTotal.TabIndex = 21
        txtTotal.Text = "0"
        txtTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.asdasd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(txtTotal)
        Controls.Add(lblTotal)
        Controls.Add(btnReceipt)
        Controls.Add(btnPlaceOrder)
        Controls.Add(txtClear)
        Controls.Add(txtYumburger)
        Controls.Add(btnYumburgerPlus)
        Controls.Add(btnYumburgerMinus)
        Controls.Add(txtHotdog)
        Controls.Add(btnHotdogPlus)
        Controls.Add(btnHotdogMinus)
        Controls.Add(txtFries)
        Controls.Add(btnFriesPlus)
        Controls.Add(btnFriesMinus)
        Controls.Add(txtBurger)
        Controls.Add(btnBurgerPlus)
        Controls.Add(btnBurgerMinus)
        Controls.Add(lblYumburger)
        Controls.Add(lblHotdog)
        Controls.Add(lblFries)
        Controls.Add(lblBurger)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBurger As Label
    Friend WithEvents lblFries As Label
    Friend WithEvents lblHotdog As Label
    Friend WithEvents lblYumburger As Label
    Friend WithEvents btnBurgerMinus As Button
    Friend WithEvents btnBurgerPlus As Button
    Friend WithEvents txtBurger As TextBox
    Friend WithEvents txtFries As TextBox
    Friend WithEvents btnFriesPlus As Button
    Friend WithEvents btnFriesMinus As Button
    Friend WithEvents txtHotdog As TextBox
    Friend WithEvents btnHotdogPlus As Button
    Friend WithEvents btnHotdogMinus As Button
    Friend WithEvents txtYumburger As TextBox
    Friend WithEvents btnYumburgerPlus As Button
    Friend WithEvents btnYumburgerMinus As Button
    Friend WithEvents txtClear As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnReceipt As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox

End Class
