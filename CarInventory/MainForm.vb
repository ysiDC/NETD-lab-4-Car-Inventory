'' Program name:        Car Inventory
'' Author:              Simon Yarrow (100738683)
'' Course:              NETD 2202
'' Date:                July 11, 2019
'' Program purpose:     This Windows form allows a user to select a car manufacturer and year of manufacture from drop-down lists, enter model
''                      name and purchase price in text boxes, and indicate whether the car is new with a check box, then submit all this data
''                      in order to populate a list view box. Data can be submitted with the Enter key or the Enter button. The Reset button
''                      or the Escape key resets the data-entry parts of the form, but not the list view box. The Exit button exits the program.
''                      If any data is missing or invalid (if the price is not a number) when the user attempts to submit it, it will not be
''                      submitted and error messages will appear in a separate label indicating the problem areas.
'' References:          A large amount of code was taken or adapted from "CustomerList" by Alfred Massardo. Some code commentary has been taken
''                      or adapted from there as well.

Option Strict On

''' <summary>
''' The main form of the program.
''' </summary>
Public Class MainForm

    Private vehicleList As New SortedList   ' Collection of all the vehicles that have been created/that are displayed in the list view
    ' The ID number of the currently selected vehicle (it's a string in the vehicleList dictionary)
    Private currentVehicleIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False     ' Whether or not the items in the list view can be edited in place
    ' (This is relevant for the check boxes in the lefthand column: their status will be locked except
    ' when the btnEnter_Click event handler is altering them).

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated, a vehicle object will be created using the  
    '''                - parameterized constructor. The new customer object will also be inserted
    '''                - into the vehicleList collection. This subroutine will also check to see if
    '''                - the data in the controls has been selected from the listview by the user.
    '''                - In that case, it will need to update the data in that specific vehicle object
    '''                - and the list view as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim vehicle As Vehicle              ' Declare a new Vehicle
        Dim vehicleItem As ListViewItem     ' Declare a new ListViewItem

        ' Use a subroutine to validate the data in the form. If it's successfully validated...
        If IsValidInput() = True Then

            ' Set the edit flag to true
            editMode = True

            ' If the ID number of the current vehicle is an empty string (which it is set to when the Reset subroutine is called,
            ' but which it will not be if an existing vehicle has been selected from the list view)...
            If currentVehicleIdentificationNumber.Trim.Length = 0 Then
                ' This is a new entry, so create a new Vehicle object using the paramaterized constructor and the form data
                vehicle = New Vehicle(cmbMake.Text, tbModel.Text.Trim, CInt(cmbYear.Text), CDbl(tbPrice.Text), chkNewStatus.Checked)
                ' Retrieve this Vehicle object's ID number, then make a new entry in the collection with the ID number as a key
                ' and the object as the corresponding value
                vehicleList.Add(vehicle.IdentificationNumber.ToString(), vehicle)
            Else    ' The vehicle has an ID number (so it has been selected from the list view)...
                ' Give the vehicle with this ID number the properties currently in the form
                vehicle = CType(vehicleList.Item(currentVehicleIdentificationNumber), Vehicle)
                vehicle.Make = cmbMake.Text
                vehicle.Model = tbModel.Text
                vehicle.Year = CInt(cmbYear.Text)
                vehicle.Price = CDbl(tbPrice.Text)
                vehicle.NewStatus = chkNewStatus.Checked
            End If

            ' Clear the list view
            lvwVehicles.Items.Clear()

            ' For each object in the dictionary, create a new ListViewItem, give it the properties of that object,
            ' then add it to the list view
            For Each vehicleEntry As DictionaryEntry In vehicleList
                vehicleItem = New ListViewItem()
                vehicle = CType(vehicleEntry.Value, Vehicle)
                vehicleItem.Checked = vehicle.NewStatus
                vehicleItem.SubItems.Add(vehicle.IdentificationNumber.ToString())
                vehicleItem.SubItems.Add(vehicle.Make)
                vehicleItem.SubItems.Add(vehicle.Model)
                vehicleItem.SubItems.Add(vehicle.Year.ToString)
                vehicleItem.SubItems.Add(FormatCurrency(vehicle.Price, 2))
                lvwVehicles.Items.Add(vehicleItem)
            Next vehicleEntry

            ' Reset the form (note: this does not empty the list view)
            Reset()

            ' Output a message that data entry or editing was successful (this has to be after call to Reset, which clears the Result label)
            lblResult.Text = "It worked!"

            ' Reset the edit mode variable (to ensure the check boxes in the list view cannot be altered by the user)
            editMode = False

        End If
    End Sub

    ''' <summary>
    ''' Subroutine to reset the form (note: this does not empty the list view, so it does not restore the form to
    ''' its original state).
    ''' </summary>
    Private Sub Reset()

        ' None of the manufacturers in the drop-down list are selected
        cmbMake.SelectedIndex = -1
        ' Empty the text box for the model name
        tbModel.Text = String.Empty
        ' None of the years of manufacturer in the drop-down list are selected
        cmbYear.SelectedIndex = -1
        ' Empty the text box for the price
        tbPrice.Text = String.Empty
        ' Ensure the check box indicating the car is new is unchecked
        chkNewStatus.Checked = False
        ' Clear any errors from the result label
        lblResult.Text = String.Empty

        ' Set the ID number to an empty string
        currentVehicleIdentificationNumber = String.Empty

        ' Ensure no items in the list view are selected
        ' (ADDING THIS LINE FIXES ERRORS IN lvwVehicles_SelectedIndexChanged BELOW)
        lvwVehicles.SelectedItems.Clear()

        ' Return focus to the first user input field
        cmbMake.Focus()

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True   ' The value to be returned: whether or not the form input is all valid
        Dim outputMessage As String = String.Empty  ' The error message to be sent to the "result" label (by default, nothing)
        Dim doubleForTryParse As Double = 0.0D  ' Performing TryParse on a string must have a double to which to assign the result

        ' FOR ALL OF THE FOLLOWING: check the validity of the input in that particular input field, and if it is not valid,
        ' add an error relevant to that field to the output message and set the return value to false.

        ' If no manufacturer has been selected from the drop-down list...
        If cmbMake.SelectedIndex = -1 Then
            outputMessage += "Please select the vehicle's make." & vbCrLf
            returnValue = False
        End If

        ' If nothing has been entered in the text box for the model...
        If tbModel.Text.Trim.Length = 0 Then
            outputMessage += "Please enter the vehicle's model name." & vbCrLf
            returnValue = False
        End If

        ' If no year of manufacture has been selected from the drop-down list...
        If cmbYear.SelectedIndex = -1 Then
            outputMessage += "Please select the vehicle's year." & vbCrLf
            returnValue = False
        End If

        ' If nothing has been entered in the text box for the price...
        If tbPrice.Text.Trim.Length = 0 Then
            outputMessage += "Please enter the vehicle's price." & vbCrLf
            returnValue = False
            ' ...otherwise, if what has been entered as the price cannot be parsed as a double...
        ElseIf Not (Double.TryParse(tbPrice.Text, doubleForTryParse)) Then
            outputMessage += "Please enter a number for the vehicle's price." & vbCrLf
            returnValue = False
            ' ...otherwise, if what has been entered is a double but is less than zero...
            ' (The variable doubleForTryParse was initialized to 0, so it could only be < 0
            ' if the input successfully parsed to a negative number)
        ElseIf (doubleForTryParse < 0) Then
            outputMessage += "Price cannot be negative." & vbCrLf
            returnValue = False
        End If

        ' If any one of the above tests has set the return value to false, display any error messages they generated
        ' in the result label
        If returnValue = False Then
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage
        End If

        ' Return whether all the data is valid
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form.
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Call the Reset subroutine
        Reset()
    End Sub

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form.
    ''' The code in the btnExit_Click EventHandler will close the application.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Tell the form to close itself
        Me.Close()
    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - Used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode (in effect, the check boxes in the list
    '''                        - view can only be changed by the btnEnter_Click event handler,
    '''                        - because editMode only becomes true when that handler is updating info
    '''                        - or entering new info)
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">ItemCheckEventArgs</param>
    Private Sub lvwVehicles_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwVehicles.ItemCheck

        ' If the form is not in edit mode...
        If editMode = False Then
            ' The checked status of the list view check box the user has clicked on retains its status (checked/unchecked)
            e.NewValue = e.CurrentValue
        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - When the user selects a row in the list view, this will populate
    '''                                     the input fields for editing.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub lvwVehicles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwVehicles.SelectedIndexChanged

        ' Constant that represents the index of the subitem in the list that holds the customer identification number
        ' (In other words, the first subitem of every vehicle item in the list is always that vehicle's ID number)
        Const identificationSubItemIndex As Integer = 1

        ' (The following code is surrounded in an "if" statement to fix a crash that would otherwise occur when one line
        ' in the list view was selected, then another was immediately selected. The issue seems to be that that action
        ' double-triggers the event - once on leaving the old selection and once on entering the new selection - which
        ' means the first instance results in no value for "lvwVehicles.FocusedItem.Index" since nothing is selected.
        ' See also the added line in the Reset subroutine above.)

        ' If at least one item in the list view is selected...
        If (lvwVehicles.SelectedItems.Count > 0) Then
            ' Set the ID number of the current vehicle to that of the item (vehicle) selected in the list view
            currentVehicleIdentificationNumber = lvwVehicles.Items(lvwVehicles.FocusedItem.Index).SubItems(identificationSubItemIndex).Text
            ' Use the vehicle ID number to get the vehicle from the collection
            Dim vehicle As Vehicle = CType(vehicleList.Item(currentVehicleIdentificationNumber), Vehicle)
            ' Fill in the data entry fields in the form using the appropriate data from the current vehicle object
            cmbMake.Text = vehicle.Make
            tbModel.Text = vehicle.Model
            cmbYear.Text = vehicle.Year.ToString
            tbPrice.Text = vehicle.Price.ToString
            chkNewStatus.Checked = vehicle.NewStatus
        End If

    End Sub

End Class