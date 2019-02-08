/*
 * 复合模式：
 *
 * Head First：
 *
 * 复合模式是指一群模式被结合起来使用，以解决一般性问题。
 *
 * 在Example1中，先是创建了IQuackable接口来让Duck叫，然后出现了一只Goose鹅，
 * 它希望可以像IQuackable一样叫，于是使用了适配器模式（Adapter）；然后我们
 * 需要统计呱呱叫的次数，所以使用装饰者（Decorator）并且使用抽象工厂（Factory)
 * 直接生产带有QuackCounter装饰者的Duck；接着我们把鸭子使用组合模式（Composite）
 * 来进行分组管理，并使用迭代器模式（Iterator）来遍历组内的鸭子；最后，
 * 呱呱叫学家希望呱呱声响起时会被通知，所以采用了观察者模式（Observer）来
 * 观察这群鸭子。
 *
 * 在Example2中，创建了一个MVC模式，DJView负责显示，同时通过观察者模式(Observer)
 * 对BeatModel进行观察。BeatModel存储着数据，在这里即音量大小，当音量发生改变时，
 * 会通知DJView。BeatController是具体的逻辑操作，例如按下音量减小键时在controller
 * 里将model的音量减少，然后model会通知订阅的音量变化的view做出响应。
 */
 