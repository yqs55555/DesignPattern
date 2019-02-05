/*
 * 代理模式：
 *
 * Head First：
 *
 * 代理模式为另一个对象提供一个替身或占位符以控制对这个
 * 对象的访问。
 *
 * 在Example1中，我们创建了一个GumballMonitor作为一个简单的代理来查看
 * GumballMachine中发生的变化。
 *
 * 在Example2中，则是添加了IInvocationHandler来构建保护代理，由于C#
 * 与Java语法不同的原因，这里用自己构建的一个反射来完成这个保护代理，
 * 使得需要调用IInvocationHandler来调用Person的方法。
 * 后续可以参考 https://blog.csdn.net/weixin_37390956/article/details/79947976 进行实现
 */
