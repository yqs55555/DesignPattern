/*
 * 组合模式：
 *
 *  Head First：
 *
 * 组合模式允许你将对象组成树形结构来表现“整体/部分”的层次结构。
 * 组合能让客户以一致的方式处理个别对象和对象组合。
 *
 * 在Example1中，MenuComponent是一个组合迭代器，Menu和MenuItem分别继承自它，其中，
 * Menu是一个具有子节点的菜单，并且子节点可能为其他Menu或者MenuItem；而MenuItem则是
 * 不会有子节点的叶节点。所以在Example1Test中，我们创建了一个allMenu作为这颗组合树
 * 的根节点，然后使用迭代器来遍历这棵树。
 */