<?php
function get_products() {
  return [
    '1' => [
      'title' => 'Подвесная кровать Асусмер',
      'img_url' => 'img/item-asusmer.jpg',
      'price' => 10000,
      'discount' => 1000,
      'is_new' => true,
      'is_last' => false,
      'type' => 'furniture',
      'colors' => ['color-blue'],
      'features' => ['Радует котов', 'Вызывает зависть', 'Прочно висит', 'Мягкая', 'Стильная', 'Твоя', 'Качает не по-детски', 'Ждёт тебя дома']
    ],
    '2' => [
      'title' => 'Кресло Бадета',
      'img_url' => 'img/item-badeta.jpg',
      'price' => 3500,
      'discount' => 0,
      'is_new' => false,
      'is_last' => false,
      'type' => 'furniture',
      'colors' => ['color-blue', 'color-black'],
      'features' => ['Раскачает квартиру', 'Уютное', 'Прочно висит', 'Словно бабушка связала']
    ],
    '3' => [
      'title' => 'Стикеры Блемпере',
      'img_url' => 'img/item-blempere.jpg',
      'price' => 500,
      'discount' => 0,
      'is_new' => false,
      'is_last' => true,
      'type' => 'other',
      'colors' => ['color-blue', 'color-black', 'color-red'],
      'features' => ['Клеются намертво', 'Яркие', 'Смешные', 'Стильные', 'Не стираются']
    ],
    '4' => [
      'title' => 'Лампа Блетуб',
      'img_url' => 'img/item-bletub.jpg',
      'price' => 4000,
      'discount' => 0,
      'is_new' => true,
      'is_last' => true,
      'type' => 'lighting',
      'colors' => ['color-red'],
      'features' => ['Кот не достанет', 'Прочно висит', 'Ярко светит']
    ],
    '5' => [
      'title' => 'Органайзер Бреирбери',
      'img_url' => 'img/item-breirberi.jpg',
      'price' => 5000,
      'discount' => 3000,
      'is_new' => true,
      'is_last' => true,
      'type' => 'other',
      'colors' => ['color-yellow'],
      'features' => ['Хлам всегда рядом', 'Удобный', 'Можно готовить и смотреть кино']
    ],
    '6' => [
      'title' => 'Лампа Мсеюлида',
      'img_url' => 'img/item-mseyulida.jpg',
      'price' => 4000,
      'discount' => 500,
      'is_new' => true,
      'is_last' => false,
      'type' => 'lighting',
      'colors' => ['color-orange', 'color-green', 'color-yellow', 'color-blue', 'color-black'],
      'features' => ['Под любой интерьер', 'Крепко стоит']
    ],
    '7' => [
      'title' => 'Диван Рмаериби',
      'img_url' => 'img/item-rmaeribi.jpg',
      'price' => 15000,
      'discount' => 4500,
      'is_new' => true,
      'is_last' => true,
      'type' => 'furniture',
      'colors' => ['color-green', 'color-black', 'color-red', 'color-blue'],
      'features' => ['Мягкий', 'Уютный', 'Любят коты и дети', 'Не видно пятен', 'Легко моется']
    ],
    '8' => [
      'title' => 'Рабочий стол Ннулм',
      'img_url' => 'img/item-nnulm.jpg',
      'price' => 5000,
      'discount' => 0,
      'is_new' => true,
      'is_last' => false,
      'type' => 'furniture',
      'colors' => ['color-green'],
      'features' => ['Экологичный', 'Много ящиков', 'Есть место для кружки и кучи бумажек']
    ],
    '9' => [
      'title' => 'Набор мебели Тре',
      'img_url' => 'img/item-tre.jpg',
      'price' => 20000,
      'discount' => 3000,
      'is_new' => true,
      'is_last' => true,
      'type' => 'furniture',
      'colors' => ['color-yellow', 'color-black'],
      'features' => ['Расслабляет', 'Не скрипит', 'Круто выглядит']
    ],
    '10' => [
      'title' => 'Люстра как у бабушки',
      'img_url' => 'img/item-default-old-lamp.jpg',
      'price' => 7000,
      'discount' => 2000,
      'is_new' => false,
      'is_last' => true,
      'type' => 'lighting',
      'colors' => ['color-blue', 'color-black'],
      'features' => ['Вызывает ностальгию', 'Впишется в любой интерьер', 'Соседи будут завидовать', 'Стильная']
    ],
    '11' => [
      'title' => 'Лампа Дo',
      'img_url' => 'img/item-do.jpg',
      'price' => 3500,
      'discount' => 500,
      'is_new' => true,
      'is_last' => false,
      'type' => 'lighting',
      'colors' => ['color-black'],
      'features' => ['Красиво стоит', 'Светит']
    ],
    '12' => [
      'title' => 'Панно Туета',
      'img_url' => 'img/item-tueta.jpg',
      'price' => 5000,
      'discount' => 20,
      'is_new' => true,
      'is_last' => true,
      'type' => 'textile',
      'colors' => ['color-red'],
      'features' => ['Удивляет гостей', 'Хочется потрогать', 'Притягивает взгляды']
    ],
    '13' => [
      'title' => 'Подушка Нмяо',
      'img_url' => 'img/item-nmyao.jpg',
      'price' => 1500,
      'discount' => 0,
      'is_new' => false,
      'is_last' => false,
      'type' => 'textile',
      'colors' => ['color-orange'],
      'features' => ['Уютно коту', 'Удобно тебе', 'Весело ребёнку']
    ],
    '14' => [
      'title' => 'Лампа Кел',
      'img_url' => 'img/item-kel.jpg',
      'price' => 3000,
      'discount' => 20,
      'is_new' => true,
      'is_last' => false,
      'type' => 'lighting',
      'colors' => ['color-orange', 'color-blue'],
      'features' => ['Помогает читать ночью', 'Небольшая', 'Уюнто светит', 'Не мешает другим']
    ],
    '15' => [
      'title' => 'Подушка Омасе',
      'img_url' => 'img/item-omase.jpg',
      'price' => 2000,
      'discount' => 100,
      'is_new' => true,
      'is_last' => true,
      'type' => 'textile',
      'colors' => ['color-grey', 'color-black'],
      'features' => ['Яркая', 'Квадратная', 'Мягкая']
    ],
    '16' => [
      'title' => 'Корзина Орму',
      'img_url' => 'img/item-ormu.jpg',
      'price' => 2200,
      'discount' => 20,
      'is_new' => true,
      'is_last' => false,
      'type' => 'other',
      'colors' => ['color-blue'],
      'features' => ['Поместится всё', 'Можно посадить цветок', 'Спрячет кота']
    ],
    '17' => [
      'title' => 'Скрепки Пинас',
      'img_url' => 'img/item-pinas.jpg',
      'price' => 100,
      'discount' => 0,
      'is_new' => true,
      'is_last' => true,
      'type' => 'other',
      'colors' => ['color-blue', 'color-black'],
      'features' => ['Не ржавеют', 'Крепкие', 'Их много', 'Хватит надолго']
    ],
    '18' => [
      'title' => 'Компакт-кассета Преум',
      'img_url' => 'img/item-preum.jpg',
      'price' => 200,
      'discount' => 20,
      'is_new' => true,
      'is_last' => false,
      'type' => 'other',
      'colors' => ['color-blue', 'color-black'],
      'features' => ['Успокаивает', 'Удивит подростков', 'Можно перемотать трек карандашом']
    ],
    '19' => [
      'title' => 'Сувенир Рмоб',
      'img_url' => 'img/item-rmob.jpg',
      'price' => 1500,
      'discount' => 20,
      'is_new' => false,
      'is_last' => false,
      'type' => 'other',
      'colors' => ['color-green', 'color-orange', 'color-yellow'],
      'features' => ['Для фаната Марвел', 'Можно посадить цветок', 'Славный', 'Вызывает улыбку']
    ],
    '20' => [
      'title' => 'Люстра Ткуоко',
      'img_url' => 'img/item-tkuoko.jpg',
      'price' => 2100,
      'discount' => 1000,
      'is_new' => false,
      'is_last' => false,
      'type' => 'lighting',
      'colors' => ['color-green', 'color-orange'],
      'features' => ['Блестит', 'Сияет', 'Выглядит дорого', 'Висит']
    ],
    '21' => [
      'title' => 'Кресла Бриатуо',
      'img_url' => 'img/item-briatuo.jpg',
      'price' => 7000,
      'discount' => 5500,
      'is_new' =>  false,
      'is_last' => true,
      'type' => 'furniture',
      'colors' => ['color-blue'],
      'features' => ['Яркие', 'Глубокие', 'Красивые', 'Расслабляют', 'Удобны для спины']
    ]
  ];
}

function get_filters() {
  return [
    0 => [
      'url' => 'all',
      'name' => 'Все товары',
    ],
    1 => [
      'url' => 'lighting',
      'name' => 'Освещение',
    ],
    2 => [
      'url' => 'furniture',
      'name' => 'Мебель',
    ],
    3 => [
      'url' => 'textile',
      'name' => 'Текстиль',
    ],
    4 => [
      'url' => 'other',
      'name' => 'Прочее',
    ]
  ];
}

function get_product_attribute($id, $attr) {
  $products = get_products();
  $result = $products[$id][$attr] ?? null;
  return $result;
}
function get_product_price($id) {
  return get_product_attribute($id, 'price');
}
function get_product_title($id) {
  return get_product_attribute($id, 'title');
}
function get_img_url($id) {
  return get_product_attribute($id, 'img_url');
}
function get_product_discount($id) {
  return get_product_attribute($id, 'discount');
}
function get_product_is_new($id) {
  return get_product_attribute($id, 'is_new');
}
function get_product_is_last($id) {
  return get_product_attribute($id, 'is_last');
}

function get_product_features($id) {
  return get_product_attribute($id, 'features');
}
