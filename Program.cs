// See https://aka.ms/new-console-template for more information
using FACTORYPATTERN.Circle;
using FACTORYPATTERN.Payment;

Console.WriteLine("Hello, World!");

IPayment payment = PaymentFactory.create(PaymentMethod.GooglePay);
payment.Pay(1000.00);

IShape circleFactory = new Circle();
IShape circle = ShapeFactory.CreateShape(ShapeMethod.Circle);
circle.Draw();

IShape squareFactory = new Square();
IShape square = ShapeFactory.CreateShape(ShapeMethod.Square);
square.Draw();

IShape triangleFactory = new Triangle();
IShape traingle = ShapeFactory.CreateShape(ShapeMethod.Triangle);
traingle.Draw();

IShape rectangleFactory = new Square();
IShape rectangle = ShapeFactory.CreateShape(ShapeMethod.Rectangle);
rectangle.Draw();