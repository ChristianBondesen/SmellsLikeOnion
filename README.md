
Core --> infrastructure / applications dependencies
=====================

Implementation of interfaces and other necesary references from the core libraries goes here. Even though this a numbered as 5,
it's not a part of the onion itself. This way you will be able to use different implementations of repositories and Databases,
for the very same Domain.

In DataAccess you handle your database access, implement the interfaces defined in the DomainServices.

Sometimes you may get some data from a third part API or where you wanna fusionate your own businesslogic,
you can handle such data from third party API's in the Application Dependencies.