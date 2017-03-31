<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCashRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblItemPurchased = New System.Windows.Forms.Label()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.LblTax = New System.Windows.Forms.Label()
        Me.LblTaxAmount = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblTotalAmount = New System.Windows.Forms.Label()
        Me.LblCashRegister = New System.Windows.Forms.Label()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblCost = New System.Windows.Forms.Label()
        Me.LblCostAmount = New System.Windows.Forms.Label()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.LblItemSelected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblItemPurchased
        '
        Me.LblItemPurchased.AutoSize = True
        Me.LblItemPurchased.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemPurchased.Location = New System.Drawing.Point(40, 98)
        Me.LblItemPurchased.Name = "LblItemPurchased"
        Me.LblItemPurchased.Size = New System.Drawing.Size(118, 21)
        Me.LblItemPurchased.TabIndex = 0
        Me.LblItemPurchased.Text = "Item Purchased:"
        '
        'TxtItem
        '
        Me.TxtItem.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem.Location = New System.Drawing.Point(159, 98)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(110, 27)
        Me.TxtItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Amount of selected item:"
        '
        'TxtAmount
        '
        Me.TxtAmount.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.Location = New System.Drawing.Point(210, 142)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(58, 27)
        Me.TxtAmount.TabIndex = 3
        '
        'LblTax
        '
        Me.LblTax.AutoSize = True
        Me.LblTax.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTax.Location = New System.Drawing.Point(136, 270)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(38, 21)
        Me.LblTax.TabIndex = 4
        Me.LblTax.Text = "Tax:"
        '
        'LblTaxAmount
        '
        Me.LblTaxAmount.AutoSize = True
        Me.LblTaxAmount.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTaxAmount.Location = New System.Drawing.Point(217, 270)
        Me.LblTaxAmount.Name = "LblTaxAmount"
        Me.LblTaxAmount.Size = New System.Drawing.Size(54, 21)
        Me.LblTaxAmount.TabIndex = 5
        Me.LblTaxAmount.Text = "$88.88"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(136, 302)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(48, 21)
        Me.LblTotal.TabIndex = 6
        Me.LblTotal.Text = "Total:"
        '
        'LblTotalAmount
        '
        Me.LblTotalAmount.AutoSize = True
        Me.LblTotalAmount.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAmount.Location = New System.Drawing.Point(193, 302)
        Me.LblTotalAmount.Name = "LblTotalAmount"
        Me.LblTotalAmount.Size = New System.Drawing.Size(78, 21)
        Me.LblTotalAmount.TabIndex = 7
        Me.LblTotalAmount.Text = "$88888.88"
        '
        'LblCashRegister
        '
        Me.LblCashRegister.AutoSize = True
        Me.LblCashRegister.Location = New System.Drawing.Point(65, 21)
        Me.LblCashRegister.Name = "LblCashRegister"
        Me.LblCashRegister.Size = New System.Drawing.Size(73, 13)
        Me.LblCashRegister.TabIndex = 8
        Me.LblCashRegister.Text = "Cash Register"
        '
        'BtnDisplay
        '
        Me.BtnDisplay.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplay.Location = New System.Drawing.Point(12, 339)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(86, 30)
        Me.BtnDisplay.TabIndex = 9
        Me.BtnDisplay.Text = "Display Cost"
        Me.BtnDisplay.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(125, 339)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(86, 30)
        Me.BtnClear.TabIndex = 10
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(240, 339)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(86, 30)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblCost
        '
        Me.LblCost.AutoSize = True
        Me.LblCost.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCost.Location = New System.Drawing.Point(136, 234)
        Me.LblCost.Name = "LblCost"
        Me.LblCost.Size = New System.Drawing.Size(43, 21)
        Me.LblCost.TabIndex = 12
        Me.LblCost.Text = "Cost:"
        '
        'LblCostAmount
        '
        Me.LblCostAmount.AutoSize = True
        Me.LblCostAmount.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostAmount.Location = New System.Drawing.Point(193, 234)
        Me.LblCostAmount.Name = "LblCostAmount"
        Me.LblCostAmount.Size = New System.Drawing.Size(78, 21)
        Me.LblCostAmount.TabIndex = 13
        Me.LblCostAmount.Text = "$88888.88"
        '
        'LblItem
        '
        Me.LblItem.AutoSize = True
        Me.LblItem.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItem.Location = New System.Drawing.Point(136, 200)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(41, 21)
        Me.LblItem.TabIndex = 14
        Me.LblItem.Text = "Item"
        '
        'LblItemSelected
        '
        Me.LblItemSelected.AutoSize = True
        Me.LblItemSelected.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemSelected.Location = New System.Drawing.Point(224, 200)
        Me.LblItemSelected.Name = "LblItemSelected"
        Me.LblItemSelected.Size = New System.Drawing.Size(45, 21)
        Me.LblItemSelected.TabIndex = 15
        Me.LblItemSelected.Text = "Label"
        '
        'FrmCashRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 507)
        Me.Controls.Add(Me.LblItemSelected)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.LblCostAmount)
        Me.Controls.Add(Me.LblCost)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.LblCashRegister)
        Me.Controls.Add(Me.LblTotalAmount)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblTaxAmount)
        Me.Controls.Add(Me.LblTax)
        Me.Controls.Add(Me.TxtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtItem)
        Me.Controls.Add(Me.LblItemPurchased)
        Me.Name = "FrmCashRegister"
        Me.Text = "Cash Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblItemPurchased As System.Windows.Forms.Label
    Friend WithEvents TxtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblTax As System.Windows.Forms.Label
    Friend WithEvents LblTaxAmount As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents LblCashRegister As System.Windows.Forms.Label
    Friend WithEvents BtnDisplay As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LblCost As System.Windows.Forms.Label
    Friend WithEvents LblCostAmount As System.Windows.Forms.Label
    Friend WithEvents LblItem As System.Windows.Forms.Label
    Friend WithEvents LblItemSelected As System.Windows.Forms.Label

End Class
