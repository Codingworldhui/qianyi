
const productList = document.querySelector(".product-list");
const itemsPerPage = 6;
let currentPage = 1;
function showPage(page) {
    const products = document.querySelectorAll(".product-item");
    for (let i = 0; i < products.length; i++) {
        if (i >= (page - 1) * itemsPerPage && i < page * itemsPerPage) {
            products[i].style.display = 'block';
        } else {
            products[i].style.display = 'none';
        }
    }
}
document.getElementById('page1').addEventListener('click', () => {
    currentPage = 1;
    showPage(currentPage);
});

document.getElementById('page2').addEventListener('click', () => {
    currentPage = 2;
    showPage(currentPage);
});

showPage(currentPage);
function sortSelect() {
    var sortOption = document.getElementById("sortOption");
    var selectedOption = sortOption.value;
    if (selectedOption === "priceLowToHigh") {
        products.sort(function (a, b) {
            return a.Price - b.Price;
        });
    } else if (selectedOption === "priceHighToLow") {
        products.sort(function (a, b) {
            return b.Price - a.Price;
        });
    } 
    updateProductList();
}

function updateProductList() {
    var productList = document.querySelector(".product-list");
    productList.innerHTML = ""; // 清空产品列表
    // 重新渲染排序后的产品列表
    products.forEach(function (product) {
        var productItem = document.createElement("div");
        productItem.className = "product-item";
        var productLink = document.createElement("a");
        productLink.href = product.ImageUrl;
        var productImage = document.createElement("img");
        productImage.src = product.ImageUrl;
        productImage.alt = product.Category;
        var productInfo = document.createElement("div");
        productInfo.className = "product-info";
        var productName = document.createElement("h3");
        productName.textContent = product.Name;
        var productPrice = document.createElement("span");
        productPrice.textContent = product.Price;
        var productDescription = document.createElement("p");
        productDescription.textContent = product.Description;
        productInfo.appendChild(productName);
        productInfo.appendChild(productPrice);
        productInfo.appendChild(productDescription);
        productLink.appendChild(productImage);
        productItem.appendChild(productLink);
        productItem.appendChild(productInfo);
        productList.appendChild(productItem);
        showPage(currentPage);
    });
}
function searchProducts() {
    var productContainer = document.querySelector(".product-list");
    productContainer.innerHTML = ""; // 清空产品容器
    var searchInput = document.getElementById("searchInput");
    var searchTerm = searchInput.value.toLowerCase(); // 获取用户输入并转为小写以进行不区分大小写的搜
    var filteredProducts = products.filter(function (product) {
        // 根据产品的名称或其他属性进行搜索
        return product.Name.toLowerCase().includes(searchTerm) ||
            product.Description.toLowerCase().includes(searchTerm);
    });
    // 更新产品列表
    update(filteredProducts);
}

function update(filteredProducts) {
    var productContainer = document.querySelector(".product-list");
    productContainer.innerHTML = ""; // 清空产品容器
    // 重新渲染筛选后的产品
    filteredProducts.forEach(function (product) {
        var productItem = document.createElement("div");
        productItem.classList.add("product-item");
        var productLink = document.createElement("a");
        productLink.href = product.ImageUrl;
        var productImage = document.createElement("img");
        productImage.src = product.ImageUrl;
        productImage.alt = product.Category;
        var productInfo = document.createElement("div");
        productInfo.classList.add("product-info");
        var productName = document.createElement("h3");
        productName.textContent = product.Name;
        var productPrice = document.createElement("span");
        productPrice.textContent = product.Price;
        var productDescription = document.createElement("p");
        productDescription.textContent = product.Description;
        productLink.appendChild(productImage);
        productInfo.appendChild(productName);
        productInfo.appendChild(productPrice);
        productInfo.appendChild(productDescription);
        productItem.appendChild(productLink);
        productItem.appendChild(productInfo);
        productContainer.appendChild(productItem);
    });
}
 


