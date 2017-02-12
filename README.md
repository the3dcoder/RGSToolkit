# RGSToolkit
Real Green Systems Tech Toolkit (Covering utilities for Service Assistant, CAW, and Mobile Live)

-To Add (Overall)

	-Add web links for both CAW and Mobile
		-http://issues.realgreen.com/mobileliveadmin/default.aspx
		-http://rgssite.com/caw/index.asp
		-https://q.realgreen.com/Login
		-https://applog.realgreen.com/Viewer
		-https://realgreen.atlassian.net/secure/Dashboard.jspa
		-https://docs.google.com/spreadsheets/d/1eJz4zmGMk6ujs57mn0L_HjMUR_0r8aAO8_JrUeTKWXw/edit#gid=0
		-https://cawpci.realgreen.com/Test/Login_New.aspx
		
		-For CAW lookup, add ability for user to put in account number
		-and then implement the following
		
		-CAW lookup url will load with correct account number information
		-Allow user to enter account number and be taking directly to CAW admin login
			-Allow auto-login by just entering users account number
		
		
	-Error checks and invalid input checks
	-Better UI (First minor update done on 2/12)
	-Further SQL integration
	-Complete the general menu option
	-Minimize forms
	-Ability to log into SQL4 (using sql auth - need sa password)
	-Clean the code up
	-Add a timer to track script/code speed (possible progress bar to assure progress)

-To Add (CAW):

	-Add sorting and choices for amount of data. 10/50/100 results
	-Ability to export SELECTED CAW data in multiple formats (to be determined)
		-Excel
		-Text
	-Ability to email CAW information to customer support emails
	-Work in additional CAW scripts
	-Autopay profiles

-To Add (Mobile):

	-Display whether the Android Service is on with green/red indicator
	-Allow user to input email for where to email template (possible 
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


	

