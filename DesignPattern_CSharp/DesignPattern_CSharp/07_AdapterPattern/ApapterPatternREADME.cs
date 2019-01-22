/*
 * 适配器模式：
 *
 * Head First：
 *
 * 适配器模式将一个类的接口转换成客户期望的另一个接口。
 * 适配器让原本接口不兼容的类可以合作无间。
 *
 * 在Example1中：
 * ClassAdapter：类适配器，通过直接实现两个接口IDuck（Target）和ITurkey（Adaptee）来达成目的
 * 其中Target一般使用具体类而非接口
 * ObjectAdapter：对象适配器，通过组合的方式，即Adapter实现IDuck接口但是内部实际
 * 拥有一个ITurkey（构造时传入）来实现
 */
