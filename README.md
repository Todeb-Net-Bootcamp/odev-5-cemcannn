# Fifth Week Homework

1. Business, Presentation and DTO layers were created.
- In **Business** layer **Abstract** and **Concrete** classes were created. The **Abstract** class contains the **ICustomerService** interface. 
There are **FastEatGrossCenter** and **FoodCityGrossCenter** classes in Concrete. In addition, there is a **Configuration** file in the **Business** layer and there are **Extension, Validator, Response** and **Mapper** files in **Configuration**.
- In **DTO** layer, DTOs are classes in which database models are stored. 
- In **Presentation** (Web Api) layer, there are **Controllers, appsettings.Development, Program** and **Startup**. 

2. **FluentValidation** and **AutoMapper** were installed in *Business* layer, added in *Business* layer *Configuration* folder and implemented. 3 Type of validators were created in **Validator** class. These validators and mapper profiles were used in **Business** layer **Concrete** classes. 
3. **Startup** file was edited. In **ConfigureServices**, **Dependency Injections** were added. 

4. The project was opened via **Swagger**, **Post, Put, Delete** and **Get** methods are working without any problems.

