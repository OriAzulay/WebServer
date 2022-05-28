<h2>Web Chat Application - Server Side</h2>

**Before Running :**
To Make sure you have all set.
Please run Update-Databest , and check both tables of Users + Contacts (these are urgent to have)

**Running Program:**
Before starting to run the project on VSCode, make sure you are on WebServer run (not IIS EXPRESS).
Once you start running you will see the main page in chrome which is Login Page that looks like this:
URL for Login could be : "https://localhost:7182" OR https://localhost:7182/Users/Login
//extra : http://localhost:5182"


You can move to the SigUp Page by clicking the button in Login (click here to register)
and the url will be https://localhost:7182/Users/Signup
It should looks like this:


After you signup with a new user it will be save at the db table Users) - again you may have to update the db to see it.



___________________________________________________________________________________________________________________________
REST API:

As we learned about API controller, we can run it in this way https://localhost:7182/api/contacts 
contacts: is the name of our API controller.
Once running the link it should gives you GetAll users method 


