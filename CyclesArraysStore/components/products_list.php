<section class="catalog">
  <a href="catalog.php?product_type=all">Показать всё&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>
  <a href="catalog.php?product_type=furniture">Фурнитура&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>
  <a href="catalog.php?product_type=lighting">Свет&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>
  <a href="catalog.php?product_type=textile">Текстиль&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>
  <a href="catalog.php?product_type=other">Остальное</a>
  <div class="container">
    <h1 class="catalog-title">Каталог товаров</h1>
    <ul class="products-list">
      <?php foreach ($items as $item): ?>
        <?php if ($item['type'] === $type or $type==='all'): ?>
      <li>
        <a class="product-card" href="product.php?product_id=<?=$id ?>">
          <h3><?=$item['title']?></h3>
          <img src="<?=$item['img_url']?>" width="156" height="120" alt="<?=$item['title']?>">
          <div class="product-options">
          <span class="price"><?=$item['price']?></span>
          <ul class="colors-list">
            <?php foreach ($item['colors'] as $color): ?>
              <li class="<?=$color?>"></li>
            <?php endforeach;?>
          </ul>
          </div>
        </a>
      </li>
        <?php endif; ?>
        <?php $id++; ?>
      <?php endforeach;?>
    </ul>
  </div>
</section>
