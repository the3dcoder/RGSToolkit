# RGSToolkit
Real Green Systems Tech Toolkit (Covering utilities for Service Assistant, CAW, and Mobile Live)

-To Add (Overall)

	-Error checks and invalid input checks
	-Better UI (First minor update done on 2/12)
	-Complete the general menu option
	-Minimize forms
	-Ability to log into SQL4 (using sql auth - need sa password)
	-Clean the code up

-To Add (CAW):

	-Ability to export CAW data in multiple formats (to be determined)
	-Ability to email CAW information to customer support emails
	-Work in additional CAW scripts
	-Autopay profiles

-To Add (Mobile):

	-Display whether the Android Service is on
	-Display token, web service id's and other info in better ways 
	-Create a standalone version of this tool and a customer client version

--Current Capabilities for Mobile Live:
 
	-Generates a QR Code for the Token and Webservice. Displaying it to the user both in QR code form and text form which can be copied.
	-Checks for all possible outcomes (hosted, non-hosted, webservices, android only companies, etc).
	-QR codes generate properly and displays appropriate message to signal hosted or android customers.
	-Generates android icon for android customers
	-Export template allows user to save the generated QR sheet in currently 3 possible formats (jpg, gif, bmp)
	-Exported emplate has generated QR codes on the sheet.
	-Ability to email created file to a customers email to quickly respond to support calls.
	-Currently default name for the emailed attachment is "newQRsheet.jpg". - possibly add custom naming later
	-Ability to clear out and run as many queries as you want without closing the program

--CAW Capabilities

	-Server/Database connection page allows for automatic filling of databases in a list based of a pre-chosen server.
	-Shows: Las Sync Completed Time (and displays last 10)
	-Most Recent Payment (and most recent 10, as well as their amounts and account numbers)
	-Site ID and Current Server/Database Connections
	-Ability to Decrypt and see a registered users password
	-Ability to clear all sync data and lists to re-query the program, so no more restarted needed
	-Ability to reconnect to another database and continue work
	-If a field is selected in any of the lists, it will highlight the identical index's in the other lists, 
		keeping things organized for the eyes


	

