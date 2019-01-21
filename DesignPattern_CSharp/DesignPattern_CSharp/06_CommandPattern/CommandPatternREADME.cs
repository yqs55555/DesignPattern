﻿/*
 * 命令模式：
 *
 * Head First：
 *
 * 命令模式将“请求”封装成对象，以便使用不同的请求、队列或者日志来参数化其他对象。
 * 命令模式也支持可撤销的操作。
 *
 * 在Example中，RemoteControl是一个有着7个插槽的遥控器，每个插槽对应两个按钮（On和Off）
 * 所以，我们将每个按钮对应一个Command，构成了命令模式
 */