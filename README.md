# Grad4BriteHack17
Brite4Grad Hackathon 2017

## Tips for the hackathon
* Your most limited resource is TIME, come prepared with a plan and have regular check points!
* Collaboration is crucial, have everyone on board so they can pull in same direction.
* Don't spread yourself to thin, find the key thing you want to accomplish and focus on delivering that
* The slution provides a starting point, a resource only. You can use any technology but mind your time constraints.
* You can already start working on the solution when you get this, the more you get done before the less pressure on Saturday

## Technology Stack
* FE: JQuery
* FE: KnockoutJS
* FE: Bootstrap
* FE: Slick Carousel
* FE: Microsoft .NET MVC
* DI: Unity
* ORM: Entity Framework

## Architecture
* A 3 tiered architecture (Presentation, BL & DAL) is used. Using the Providers (BL) or Adapters (DAL) contract you can have multiple people work on different layers once the contracts are established.
* High Cohesion but Loose Coupling (Abstraction, contracting and d* omain seperation)

_Conceptual Architecture Overview_
<img alt="Architecture Overview" src="https://raw.githubusercontent.com/BHD-ConsultingServices/Grad4BriteHack17/master/Web/Content/Images/ConceptualArchitecture.png" width="700">

## Important Places
* Swapping (DI) config between stubbed adapters and the real adapters going to the database - <Unity> Configuration in Web.config
* Run the unit tests to see the available operations on DAL and Provider level



