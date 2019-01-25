/*
 * 迭代器模式：
 *
 * Head First：
 *
 * 迭代器模式提供一个方法顺序访问一个聚合对象中的各个元素，而
 * 又不暴露其内部的表示。
 *
 * 在Example1中，创建了DinerMenuIterator作为DinerMenu的迭代器来访问
 * DinerMenu中的MenuItem集合，这样，无论MenuItem集合是以数组还是链表
 * 的形式存在都不会影响外部的访问，缺点在于C#的IEnumerator的接口不允
 * 许遍历过程中删除某个对象，这是应该尤为注意的。
 */
