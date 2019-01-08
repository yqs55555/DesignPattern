/*
 * 策略模式
 *
 * Head First：
 * 策略模式定义了算法族（行为族），分别封装起来，让它们之间可以互相替换，
 * 此模式让算法的变化独立于使用算法的客户。
 *
 * 在Example1中，Character是一个抽象类，King、Queen、Troll是它的具体实例
 * IWeaponBehavior是一个武器接口，AxeBehavior、BowAndArrowBehavior、KnifeBehavior、SwordBehavior四种具体武器实现了它
 * Character可以通过Fight使用当前装备的武器，通过SetWeapon来给角色替换装备
 *
 */
