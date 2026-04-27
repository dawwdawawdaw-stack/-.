<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head>
  <meta charset="UTF-8">
  <title>متجر ID</title>
  <link rel="stylesheet" href="styless.css"/>
</head>

<body>

<div id="cart" class="cart">
  <h2>السلة 🛒</h2>
  <div id="cart-items"></div>
  <h3 id="total">المجموع: 0 ريال</h3>
</div>

<header class="header">
  <h1>𝐕𝐚𝐥𝐚𝐫𝐲 𝐂𝐢𝐭𝐲 𝐑𝐏</h1>
<header class="header">
 

  <div class="search-box">
    <input type="text" placeholder="ابحث عن منتج...">
  </div>

  <div class="cart-icon" onclick="toggleCart()">
    🛒 <span id="cart-count">0</span>
  </div>
</header>
  
</header>

<section class="products">

  <div class="card">
    <img src="https://via.placeholder.com/300x200" alt="">
    <h3>ID SPECIAL</h3>
    <p>ايدي ثنائي عادي</p>
    <span class="price">50 ريال</span>
    <button onclick="addToCart('ايدي ثنائي عادي', 50)">إضافة للسلة</button>
  </div>

  <div class="card">
    <img src="https://via.placeholder.com/300x200" alt="">
    <h3>ID SPECIAL</h3>
    <p>ايدي رباعي</p>
    <span class="price">80 ريال</span>
    <button onclick="addToCart('ايدي رباعي', 80)">إضافة للسلة</button>
  </div>

</section>

<div class="center-logo">
  <img src="crown.png" class="crown-img">
  Valary <span>City</span> RP
</div>

<div class="badge">VIP</div>
<div class="stars">★★★★★</div>

<script src="script.js"></script>
</body>
</html>
