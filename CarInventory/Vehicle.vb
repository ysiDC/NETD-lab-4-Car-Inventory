'' Program name:        Vehicle (class definition)
'' Author:              Simon Yarrow (100738683)
'' Course:              NETD 2202
'' Date:                July 11, 2019
'' Program purpose:     This file defines the "Vehicle" class, from which vehicle objects can be created. Each vehicle has an identification
''                      number (which is unique), a make, a model, a year of manufacture, a purchase price, and a boolean value indicating
''                      whether it is new or not (in other words, used). This file itself will also keep track of how many vehicles have been created.
''                      When a new vehicle is created, the vehicle count will be incremented, then the total count will be assigned as the vehicle's
''                      identification number.
'' References:          A large amount of code was taken or adapted from "CustomerList" by Alfred Massardo. Some code commentary has been taken
''                      from there as well.Option Strict On

Public Class Vehicle


    Private Shared vehicleCount As Integer                  ' static or shared private variable to hold the number of vehicles
    Private vehicleIdentificationNumber As Integer = 0      ' private variable to hold the vehicle's identification number
    Private vehicleMake As String = String.Empty            ' private variable to hold the vehicle's make
    Private vehicleModel As String = String.Empty           ' private variable to hold the vehicle's model name
    Private vehicleYear As Integer = 0                      ' private variable to hold the vehicle's year of manufacture
    Private vehiclePrice As Double = 0.0D                   ' private variable to hold the vehicle's purchase price
    Private vehicleIsNew As Boolean = False                 ' private variable to hold whether the vehicle is new

    ''' <summary>
    ''' Constructor - Default - creates a new vehicle object
    ''' </summary>
    Public Sub New()

        vehicleCount += 1      ' Increment the shared/static variable counter by 1
        vehicleIdentificationNumber = vehicleCount ' Assign the vehicle's ID number

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new vehicle object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="isNew"></param>
    Public Sub New(make As String, model As String, year As Integer, price As Double, isNew As Boolean)

        ' Call the default constructor to increment the vehicle count and to set this vehicle's ID number
        Me.New()


        vehicleMake = make          ' Set the vehicle's make
        vehicleModel = model  ' Set the vehicle's model
        vehicleYear = year    ' Set the vehicle's year of manufacture
        vehiclePrice = price    ' Set the vehicle's purchase price
        vehicleIsNew = isNew        ' Set the vehicle's status (new or not new - i.e., used)

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of vehicles that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return vehicleCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific vehicle's identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return vehicleIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' NewStatus Property - Gets and Sets the new status of a vehicle
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property NewStatus() As Boolean
        Get
            Return vehicleIsNew
        End Get
        Set(ByVal value As Boolean)
            vehicleIsNew = value
        End Set
    End Property

    ''' <summary>
    ''' Make property - Gets and Sets the make (manufacturer) of a vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return vehicleMake
        End Get
        Set(ByVal value As String)
            vehicleMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model property - Gets and Sets the model name of a vehicle
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return vehicleModel
        End Get
        Set(ByVal value As String)
            vehicleModel = value
        End Set
    End Property

    ''' <summary>
    ''' Year property - Gets and Sets the year of manufacture of a vehicle
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property Year() As Integer
        Get
            Return vehicleYear
        End Get
        Set(ByVal value As Integer)
            vehicleYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the purchase price of a vehicle
    ''' </summary>
    ''' <returns>Double</returns>
    Public Property Price() As Double
        Get
            Return vehiclePrice
        End Get
        Set(ByVal value As Double)
            vehiclePrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetCarData()    - Returns all of this vehicle object's info in a well-formed sentence.
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetCarData() As String
        Dim isNew As String = ""    ' This variable will hold a string declaring whether the vehicle is new

        ' If the vehicle is new (vehicleIsNew is true), then the string representing this is "new", otherwise it is "used"
        If (vehicleIsNew) Then
            isNew = "new"
        Else
            isNew = "used"
        End If

        ' Return all of the vehicle's information in a sentence
        Return "The car's ID number is " & vehicleIdentificationNumber & ", its make is " & vehicleMake & ", its model is " & vehicleModel &
            ", its year of manufacture is " & vehicleYear & ", its price is " & vehiclePrice & ", and it is " & isNew + "."
    End Function

End Class
