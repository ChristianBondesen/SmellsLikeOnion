

Core --> Domain Service
=====================

Very first ring of your onion. May only reference the domain/core of your application.

You create the interfaces for communicating with your core.

Such interfaces like IGenericRepositories and other domain specific interfaces.

This is not where you implement the interfaces. It's very important to understand the fact we want to 

give the user of our arcitecture the posibility to switch among the implementations of the interfaces.