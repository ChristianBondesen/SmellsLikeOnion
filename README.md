Welcome to:

"It Smells Like Onion" - Onion Architecture Template for C#

It is important to note that this is just my take on the Onion Architecture,
I found this template to be very neat. Maybe one of the more complex of the simple templates out there.

I've made some projects using this template, one being a Web-API for a homepage with a lot of food recipies.
another being a top-up on another open API, making login logic using Identityframework and our own Business Logic for handling the 3rd part data.
This is why i implemented the second project in 4Infrastructure (feel free to delete this if your not using any 3rd part data). 

The folder structure goes as follows:

From the core out.... folders goes by number, 1 being the core/domain, 2 being the domain-service... etc...

4. folder being the infrastructure, which is not a part of the onion, this is where you will put your domain specific dependencies.

5. folder is whatever client that uses your onion, whether you made a Web API or a classic ASP.NET MVC project.

Feel free to change the name of the folder and project so it fits your specific structure :)


LandSprutte Out...