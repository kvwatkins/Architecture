namespace Prelude

module Tuple =
    let uncurry (t1, t2) = fun f -> f t1 t2
    let uncurry_3 (t1, t2, t3) = fun f -> f t1 t2 t3
    let uncurry_4 (t1, t2, t3, t4) = fun f -> f t1 t2 t3 t4
    let uncurry_5 (t1, t2, t3, t4, t5) = fun f -> f t1 t2 t3 t4 t5
    let uncurry_6 (t1, t2, t3, t4, t5, t6) =
        fun f -> f t1 t2 t3 t4 t5 t6
    let uncurry_7 (t1, t2, t3, t4, t5, t6, t7) =
        fun f -> f t1 t2 t3 t4 t5 t6 t7
    let uncurry_8 (t1, t2, t3, t4, t5, t6, t7, t8) =
        fun f -> f t1 t2 t3 t4 t5 t6 t7 t8
    let uncurry_9 (t1, t2, t3, t4, t5, t6, t7, t8, t9) =
        fun f -> f t1 t2 t3 t4 t5 t6 t7 t8 t9
    let uncurry_10 (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =
        fun f -> f t1 t2 t3 t4 t5 t6 t7 t8 t9 t10

    let curry t1 t2 = (t1,t2)
    let curry_3 t1 t2 t3 = (t1,t2,t3)
    let curry_4 t1 t2 t3 t4 = (t1,t2,t3,t4)
    let curry_5 t1 t2 t3 t4 t5 = (t1,t2,t3,t4,t5)
    let curry_6 t1 t2 t3 t4 t5 t6 =
         (t1,t2,t3,t4,t5,t6)
    let curry_7 t1 t2 t3 t4 t5 t6 t7 =
         (t1,t2,t3,t4,t5,t6,t7)
    let curry_8 t1 t2 t3 t4 t5 t6 t7 t8 =
         (t1,t2,t3,t4,t5,t6,t7,t8)
    let curry_9 t1 t2 t3 t4 t5 t6 t7 t8 t9 =
         (t1,t2,t3,t4,t5,t6,t7,t8,t9)
    let curry_10 t1 t2 t3 t4 t5 t6 t7 t8 t9 t10 =
         (t1,t2,t3,t4,t5,t6,t7,t8,t9,t10)