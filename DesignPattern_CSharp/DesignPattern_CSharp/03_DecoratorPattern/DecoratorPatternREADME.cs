/*
 * 装饰者模式
 *
 * Head First：
 * 装饰者模式动态地将责任附加到对象上。想要扩展功能，装饰者
 * 提供有别于继承的另一种选择。
 *
 * 在Example1中，我们需要用Condiment装饰Coffee，所以CondimentDecorator中会持有一个Beverage，
 * 用于表明它装饰的Beverage，这样Condiment装饰的过程中就可以将Beverage赋值为另一个Condiment，
 * 以达到层层装饰的效果。也就是说装饰者和被装饰者需要都继承自同一个类。
 *
 */
 