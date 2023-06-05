using System;
using System.Collections;
using System.Collections.Generic;

namespace OtherUsefulThings6
{

    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program6
    {


        static List<Item> _items = new List<Item>();

        // 너무 무식한 검색방법 !!
        //static Item FindWeapon()
        //{
        //    foreach (Item item in _items)
        //    {
        //        if (item.ItemType == ItemType.Weapon)
        //            return item;

        //    }
        //    return null;
        //}

        // 우아한 방법 ?? delegate
        delegate bool ItemSelector(Item item);
        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;

            }
            return null;
        }


        // 반환형식이 하나 있고 입력형식도 하나 있는 함수라면 모두 MyFunc으로 delegate할 수 있다.
        // 범용 delegate!
        // 여러 입력 상황에 따른 버전을 여러개 만들어두면 범용성이 더 좋아진다.
        // 사실 C#에 이런 친구가 Func 로 만들어져 있다 (built-in)
        // void 리턴이라면? -> Action

        /// <summary>
        /// delegate를 직접 선언하지 않아도 이미 만들어진 애들이 존재한다 (pre-made delegate)
        /// -> 반환 타입 O : Func
        /// -> 반환 타입 X : Action
        /// </summary>

        delegate Return MyFunc<T, Return>(T item); // 입력 하나, 반환 하나 
        delegate Return MyFunc<Return>(); // 입력 없이 반환만 하나 나간다 
        delegate Return MyFunc<T1, T2, Return>(T1 t1, T2 t2); // 입력 두개, 반환 하나 


        static Item FindItem2(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;

            }
            return null;
        }


        // 그래도 ItemSelector를 하나하나 만들어줘야 하니 불편하긴 하다..
        // 하나하나 다 정의해두기보다 그냥 그때그때 한번만 쓰고 버리는 함수 활용은 ?? -> labmda
        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }


        static void Main6(string[] args)
        {
            // lambda : 일회용 함수를 만드는 데 사용하는 문법.
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            Item item = FindItem(IsWeapon);

            // 무명 함수 , 익명 함수 (anonymous function)
            Item item2 = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            // 그 다음에 나온 게 Lambda
            Item item3 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

            // Lambda를 재사용하고 싶으면 ?
            ItemSelector selector2 = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });

            // MyFunc use case
            MyFunc<Item, bool> selector3 = (Item item) => { return item.ItemType == ItemType.Weapon; };
        }
    }
}
