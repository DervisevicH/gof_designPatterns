
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //SingletonDemo();
            //BuilderDemo();
            //PrototypeDemo();
            //FactoryMethodDemo();
            //AbstractFactoryDemo();

            //AdapterDemo();
            //BridgeDemo();
            CompositeDemo();
            //DecoratorDemo();
            //FlyweightDemo();
            //FacadeDemo();
            //ProxyDemo();


            //ChainOfResponsabilityDemo();
            //CommandDemo();
            //IteratorDemo();
            //MediatorDemo();
            //MementoDemo();
            //StateDemo();
            //StrategyDemo();
            //TemplateMethodDemo();
            //ObserverDemo();
            //InterpreterDemo();
            //VisitorDemo();
        }


        #region Creational
        public static void SingletonDemo()
        {
            Singleton instanceOne = Singleton.GetInstance;
            Singleton instanceTwo = Singleton.GetInstance;

            if (object.ReferenceEquals(instanceOne,instanceTwo))
            {
                Console.WriteLine($"Instance1 && instance2 are the same.");
                Console.ReadLine();
            }
        }
        public static void BuilderDemo()
        {
            Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");
            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            Toy A = toyACreator.GetToy();
            Console.WriteLine($"--Toy A-- \n Model: {A.Model}\n Head: {A.Head}\n Limbs: {A.Limbs}\n Body: {A.Body}\n Legs: {A.Legs}\n ");

            var toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            Toy B = toyBCreator.GetToy();
            Console.WriteLine($"--Toy B-- \n Model: {B.Model}\n Head: {B.Head}\n Limbs: {B.Limbs}\n Body: {B.Body}\n Legs: {B.Legs}\n ");


        }
        public static void PrototypeDemo()
        {
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
        }
        public static void FactoryMethodDemo()
        {
            //ICarSupplier objCarSupplier = CarFactory.GetCarInstance(0);
            //objCarSupplier.GetCarModel();
            //Console.WriteLine("Color is: " + objCarSupplier.CarColor);

            
            ICarFactory carFactory = new CarFactoryById(0);
            
            var objCarSupplier = carFactory.CreateCarSupplier();
            objCarSupplier.GetCarModel();
            Console.WriteLine("Color is: " + objCarSupplier.CarColor);

            carFactory = new CarFactoryByName("Suzuki");
            objCarSupplier = carFactory.CreateCarSupplier();
            objCarSupplier.GetCarModel();
            Console.WriteLine("Color is: " + objCarSupplier.CarColor);

            Console.ReadLine();

        }
        private static void AbstractFactoryDemo()
        {
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            IMobilePhone samsungMobilePhone = new SamsungPhone();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();
        }
      
        #endregion
        #region Structural
        public static void AdapterDemo()
        {
            string[,] employeesArray = new string[5, 4]
           {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
           };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
        public static void BridgeDemo()
        {
            Log log = new ApplicationLog();
            log.LogMessage = "This is log message";
            log.LogID = 111;
           
            log._registerLog = new DocumentReaderLogger();
            log.LogAppMessage();

            log._registerLog = new BrowserLogger();
            log.LogAppMessage();

            Console.ReadLine();

        }
        public static void FacadeDemo()
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR SALAD----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetChickenSalad();
            facadeForClient.GetMexicanSalad();
        }
        public static void ProxyDemo()
        {
            SimpleProxy simpleProxy = new SimpleProxy();
            simpleProxy.Authenticate("password123");
            Console.WriteLine("5+10=" + simpleProxy.ComplexOperation(5, 10).ToString());
            Console.Read();
        }
        public static void DecoratorDemo()
        {
            // Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            CarAccessoriesDecorator objAccessoriesDecorator = new AdvancedAccessories(objCar);

            objAccessoriesDecorator = new SportAccessories(objAccessoriesDecorator);

            Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();
        }
        public static void CompositeDemo()
        {
            Department salesDepartment = new SalesDepartment();
            Department financialDepartment = new FinancialDepartment();
            HeadDepartment headDepartment = new HeadDepartment();

            headDepartment.addDepartment(salesDepartment);
            headDepartment.addDepartment(financialDepartment);

            headDepartment.printDepartmentName();
            Console.ReadKey();


        }
        public static void FlyweightDemo()
        {
            GeometryFactory geometryFactory = new GeometryFactory();
            Console.WriteLine("-------------- Object Details-----------------");
            IGeometry geometry = geometryFactory.getGeometryObject("Rectangle");
            geometry.GetShape();
            geometry.GetColor(9);
            Console.WriteLine("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Rectangle");
            geometry.GetShape();
            geometry.GetColor(3);
            Console.WriteLine("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Square");
            geometry.GetShape();
            geometry.GetColor(9);
            Console.WriteLine("-------------- Object Details-----------------");
            geometry = geometryFactory.getGeometryObject("Square");
            geometry.GetShape();
            geometry.GetColor(3);
            Console.WriteLine("-------------- Object Count-----------------");
            int ObjectCount = geometryFactory.ObjectCount();
            Console.WriteLine("Total objects created: " + ObjectCount);

            Console.ReadLine();
        }
        #endregion


        #region Behavioral 
        public static void ChainOfResponsabilityDemo()
        {
            Console.Title = "Chain of Responsibility Demo";

            TeamLeader tl = new TeamLeader();
            ProjectLeader pl = new ProjectLeader();
            DeliveryManager dm = new DeliveryManager();
            Director d = new Director();
            tl.SetNextApprover(pl);
            pl.SetNextApprover(dm);
            dm.SetNextApprover(d);

            tl.ApproveLeave(3);
            tl.ApproveLeave(7);
            tl.ApproveLeave(12);
            tl.ApproveLeave(17);
            tl.ApproveLeave(22);
        }
        public static void CommandDemo()
        {
            Invoker invoker = new Invoker();
            // Execute Start Command
            ICommand command = invoker.GetCommand("Start");
            command.Execute();
            // Execute Stop Commad
            command = invoker.GetCommand("Stop");
            command.Execute();
            Console.WriteLine("Command Pattern demo");
            Console.Read();
        }
        public static void IteratorDemo()
        {
            Aggregate aggr = new Aggregate();

            aggr[0] = 7;
            aggr[1] = 8;
            aggr[2] = 9;
            aggr[3] = 89;

            IIterator iter = aggr.GetIterator();

            for (int i = iter.FirstItem; iter.IsDone == false; i = iter.NextItem)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
        public static void StrategyDemo()
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine($"Dog: {sparky.TryToFly()}");
            Console.WriteLine($"Tweety: {tweety.TryToFly()}");

            sparky.SetFlyingAbility(new ItFly());
            Console.WriteLine($"Dog: {sparky.TryToFly()}");

            Console.Read();

        }
        public static void StateDemo()
        {
            ATMMachine atmMachine = new ATMMachine();
            atmMachine.InsertCard();
            atmMachine.EjectCard();
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);
            atmMachine.RequestCash(2000);
            atmMachine.InsertCard();
            atmMachine.InsertPin(1234);

            Console.ReadKey();
        }
        public static void MementoDemo()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();
        }
        public static void MediatorDemo()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            // Wait for user

            Console.ReadKey();
        }
        public static void TemplateMethodDemo()
        {
            SourDough sourdough = new SourDough();
            sourdough.Make();


            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
        public static void ObserverDemo()
        {
            InfoService service = new InfoService();
            Student s1 = new Student("Hadzira", "Dervisevic");
            Student s2 = new Student("John", "Smith");
            service.Subscribe(s1);
            service.Subscribe(s2);
            service.AddEvent("Some new event 1");
            service.AddEvent("Some new event 2");
            Console.WriteLine("-------------------------------");
        }
        public static void InterpreterDemo()
        {
            string roman = null;

            while (!string.IsNullOrEmpty(roman = Console.ReadLine()))
            {
                Context context = new Context(roman);

                List<Expression> tree = new List<Expression>();
                tree.Add(new ThousandExpression());
                tree.Add(new HundredExpression());
                tree.Add(new TenExpression());
                tree.Add(new OneExpression());

                foreach (Expression exp in tree)
                {
                    exp.Interpreter(context);
                }

                Console.WriteLine("{0} = {1}",
                roman, context.Output);
            }

            Console.ReadKey();
        }
        public static void VisitorDemo()
        {
            List<Product> products = new List<Product>
            {
                new Tabacco(200),new Necessity(205)
            };

            Visitor pricevisitor = new Visitor();

            foreach (var item in products)
            {
                item.Accept(pricevisitor);
        
            }
            Console.WriteLine("Total Tax paid - Rs {0}.", pricevisitor.TaxToPay.ToString());
            Console.WriteLine("Basic Price Calculation - Rs {0}.", pricevisitor.TotalPrice.ToString());
            Console.WriteLine("");

            #endregion

        }
    }
}
