### 面向对象设计（OOD）
S.O.L.I.D 是面向对象设计（OOD）的头五大基本原则的首字母缩写，由俗称「鲍勃大叔」的 Robert C. Martin 提出。
#### S.O.L.I.D 代表什么:
虽然缩略词展开后看似复杂，但其实非常容易掌握。
1.    S – 单一职责原则
1.    O – 开放封闭原则
1.    L – 里氏替换原则
1.    I – 接口隔离原则
1.    D – 依赖倒置原则

让我们来单独看看每个原则，来理解为什么 S.O.L.I.D 能帮助我们成为更优秀的开发人员。
1. 单一责任原则（SRP）
  当需要修改某个类的时候原因有且只有一个。换句话说就是让一个类只做一种类型责任，当这个类需要承当其他类型的责任的时候，就需要分解这个类。 类被修改的几率很大，因此应该专注于单一的功能。如果你把多个功能放在同一个类中，功能之间就形成了关联，改变其中一个功能，有可能中止另一个功能，这时就需要新一轮的测试来避免可能出现的问题，非常耗时耗力。
2. 开放封闭原则（OCP）
软件实体应该是可扩展，而不可修改的。也就是说，对扩展是开放的，而对修改是封闭的。这个原则是诸多面向对象编程原则中最抽象、最难理解的一个。
(1)通过增加代码来扩展功能，而不是修改已经存在的代码。
(2)若客户模块和服务模块遵循同一个接口来设计，则客户模块可以不关心服务模块的类型，服务模块可以方便扩展服务(代码)。
(3)OCP支持替换的服务，而不用修改客户模块。
3. 里氏替换原则（LSP）
当一个子类的实例应该能够替换任何其超类的实例时，它们之间才具有is-A关系
客户模块不应关心服务模块的是如何工作的；同样的接口模块之间，可以在不知道服务模块代码的情况下，进行替换。即接口或父类出现的地方，实现接口的类或子类可以代入。
4. 接口分离原则（ISP）
不能强迫用户去依赖那些他们不使用的接口。换句话说，使用多个专门的接口比使用单一的总接口总要好。
客户模块不应该依赖大的接口，应该裁减为小的接口给客户模块使用，以减少依赖性。如Java中一个类实现多个接口，不同的接口给不用的客户模块使用，而不是提供给客户模块一个大的接口。
5. 依赖注入或倒置原则（DIP）
1. 高层模块不应该依赖于低层模块，二者都应该依赖于抽象
2. 抽象不应该依赖于细节，细节应该依赖于抽象
这个设计原则的亮点在于任何被DI框架注入的类很容易用mock对象进行测试和维护，因为对象创建代码集中在框架中，客户端代码也不混乱。有很多方式可以实现依赖倒置，比如像AspectJ等的AOP（Aspect Oriented programming）框架使用的字节码技术，或Spring框架使用的代理等。
(1).高层模块不要依赖低层模块；
(2).高层和低层模块都要依赖于抽象；
(3).抽象不要依赖于具体实现； 
(4).具体实现要依赖于抽象；
(5).抽象和接口使模块之间的依赖分离。