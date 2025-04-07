## Flow Diagram
[View Flow Diagram](https://docs.google.com/document/d/1Lr6FhnN-_R8tHIpzIVAWKt4mG8if2IWknzshARyipK8/edit?usp=sharing)

## Postman API Documentation
[View Postman Collection](https://documenter.getpostman.com/view/38864631/2sB2cVdM9J)


1. User Register
2. User Login
3. User will Search Rest
4. User Will Search Menus
5. User will place order
	a. From order service we will push order in rabbitMQ (QueueName -MicroserviceOrderQueue)
	b. User Can cancel order any time (before complete) (QueueName - MicroserviceCancelledOrderQueue)
		i. Cancelation order id will push to rabbitMQ
6. Delivery Service is our consumer service
	a. It will consume order from rabbitMQ (QueueName -MicroserviceOrderQueue)
	b. Here we will search delivery Partner from User Database (Delivery Partner)
	c. Select the Delivery partner and assign for delivery
	d. once delivery complete here we are updating delivery db status as 'Completed' 
		i. We are communicating with order service for updating the orderStatus as Completed (using HTTP)
		ii. We are communicating with Auth/User service for updating the Status of delivery partner as IsAvailable TRUE(using HTTP)
	d. if order is cancelled then Delivery service will consume concellation Order id from (QueueName - MicroserviceCancelledOrderQueue)
	e. Once Order cancelled delivery service will communicate with Auth/UserService to update isAvailable field as true (Delivery Partner)