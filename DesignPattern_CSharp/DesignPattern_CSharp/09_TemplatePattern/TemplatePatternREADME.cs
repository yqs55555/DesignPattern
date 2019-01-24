/*
 * 模板模式
 *
 * Head First：
 *
 * 模板模式在一个方法中定义一个算法的骨架，而将一些步骤延迟到子类中。模板
 * 方法使得子类可以在不改变算法结构的情况下，重新定义算法中的某些步骤。
 *
 * 在Example1中，由于我们需要将PrepareRecipe()方法设置为不可重载，在C#中sealed密封方法需要
 * 与override同时出现，所以构建了一个Beverage类让CaffeineBeverage继承它，然后分别在Tea和Coffee
 * 实现PrepareRecipe()中的具体算法过程。
 */
