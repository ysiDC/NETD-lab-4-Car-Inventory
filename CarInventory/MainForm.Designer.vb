<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.chkNewStatus = New System.Windows.Forms.CheckBox()
        Me.lvwVehicles = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CarInventoryTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(22, 10)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(100, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Buick", "Chevrolet", "Dodge", "Ford", "Plymouth", "Pontiac"})
        Me.cmbMake.Location = New System.Drawing.Point(128, 12)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.CarInventoryTips.SetToolTip(Me.cmbMake, "Select the car make/manufacturer from the drop-down list")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(22, 37)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(128, 39)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 20)
        Me.tbModel.TabIndex = 3
        Me.CarInventoryTips.SetToolTip(Me.tbModel, "Enter the car model name")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(22, 63)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974"})
        Me.cmbYear.Location = New System.Drawing.Point(128, 65)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 5
        Me.CarInventoryTips.SetToolTip(Me.cmbYear, "Select the car's year of manufacture from the drop-down list")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(22, 90)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(128, 92)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbPrice.TabIndex = 7
        Me.CarInventoryTips.SetToolTip(Me.tbPrice, "Enter the car's price (do not enter a currency symbol)")
        '
        'chkNewStatus
        '
        Me.chkNewStatus.AutoSize = True
        Me.chkNewStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNewStatus.Location = New System.Drawing.Point(89, 118)
        Me.chkNewStatus.Name = "chkNewStatus"
        Me.chkNewStatus.Size = New System.Drawing.Size(51, 17)
        Me.chkNewStatus.TabIndex = 8
        Me.chkNewStatus.Text = "&New:"
        Me.chkNewStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryTips.SetToolTip(Me.chkNewStatus, "Check this box if the car is new (if unchecked, the car is used)")
        Me.chkNewStatus.UseVisualStyleBackColor = True
        '
        'lvwVehicles
        '
        Me.lvwVehicles.CheckBoxes = True
        Me.lvwVehicles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwVehicles.FullRowSelect = True
        Me.lvwVehicles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwVehicles.Location = New System.Drawing.Point(13, 138)
        Me.lvwVehicles.MultiSelect = False
        Me.lvwVehicles.Name = "lvwVehicles"
        Me.lvwVehicles.Size = New System.Drawing.Size(400, 256)
        Me.lvwVehicles.TabIndex = 9
        Me.CarInventoryTips.SetToolTip(Me.lvwVehicles, "This list displays all cars that have been correctly entered. Select a car from t" &
        "he list to edit its details in the input fields above.")
        Me.lvwVehicles.UseCompatibleStateImageBehavior = False
        Me.lvwVehicles.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 66
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 66
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 67
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 67
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 67
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 67
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(13, 401)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(400, 73)
        Me.lblResult.TabIndex = 10
        Me.CarInventoryTips.SetToolTip(Me.lblResult, "When the Enter button is clicked or the Enter key is pressed, a message will appe" &
        "ar here indicating whether data entry was successful or if there are input error" &
        "s that must be addressed")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(176, 477)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CarInventoryTips.SetToolTip(Me.btnEnter, "Submit make, model, year, price, and new status to the inventory list (either as " &
        "a new car or to update an existing car)")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(257, 477)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CarInventoryTips.SetToolTip(Me.btnReset, "Reset data entry fields (make, model, year, price, and new check box) and clear a" &
        "ny errors or messages")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 477)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CarInventoryTips.SetToolTip(Me.btnExit, "Close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(425, 506)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwVehicles)
        Me.Controls.Add(Me.chkNewStatus)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(441, 545)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(441, 545)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents tbModel As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents chkNewStatus As CheckBox
    Friend WithEvents lvwVehicles As ListView
    Friend WithEvents lblResult As Label
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents CarInventoryTips As ToolTip
End Class
