Web Chat Application - Server Side

**Before Running :**
To Make sure you have all set.
Please run Update-Databest , and check both tables of Users + Contacts (these are urgent to have)

**Running Program:**
Before starting to run the project on VSCode, make sure you are on WebServer run (not IIS EXPRESS).
Once you start running you will see the main page in chrome which is Login Page that looks like this:

[![Login.jpg](https://i.postimg.cc/mgjwVC6t/Login.jpg)](https://postimg.cc/18gw3nSQ)

URL for Login could be : "https://localhost:7182" OR https://localhost:7182/Users/Login
//extra : http://localhost:5182"


You can move to the SigUp Page by clicking the button in Login (click here to register)
and the url will be https://localhost:7182/Users/Signup
It should looks like this:

Screenshot for SignUp page: [![SignUp.jpg](https://i.postimg.cc/C1L9mwNV/SignUp.jpg)](https://postimg.cc/yJtfN4tf)

After you signup with a new user it will be saved at the db table Users - again you may have to update the db to see it.

ChatBox Page : https://localhost:7182/Chat/Index
Here you have the chats with others.

Screenshot for Chat page : [![Chat.jpg](https://i.postimg.cc/Pqd75d08/Chat.jpg)](https://postimg.cc/3kb1LQ8K)

If you want to make sure that there is a direct connection between the users, you can duplicate the chatbox page and check in CONSOLE
the sending + received messages.

Screenshot for 

SignalR example: [![service.jpg](https://i.postimg.cc/JnndjPrr/service.jpg)](https://postimg.cc/HJq2g08R)
___________________________________________________________________________________________________________________________
REST API:

As we learned about API controller, we can run it in this way https://localhost:7182/api/contacts 
contacts: is the name of our API controller.
Once running the link it should gives you GetAll users method 

[![Screenshot-API.png](https://i.postimg.cc/cCZ7xVsz/Screenshot-API.png)](https://postimg.cc/njR9TS9K)

For example try GET METHOD by pasting this link https://localhost:7182/api/contacts/JimHal  

it should give you this JSON : {"id":"JimHal","name":"Jimothy","password":"12345","server":"localhost:7265","last":"video","lastDate":"17:28"}

*GET METHOD used like this: https://localhost:7182/api/contacts/id
