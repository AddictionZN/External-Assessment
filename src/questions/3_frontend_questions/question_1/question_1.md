# Question 1: Answers

## Question 1: What will the colour of both div elements be?

### First div (firstDiv):
It only receives the styling from the `.red-card` class (red) and the generic div rule (green). Since the `.red-card` rule is more specific, firstDiv will be **red**.

### Second div (secondDiv):
This element has both the `.red-card` class and an id of secondDiv. The id selector (`#secondDiv`) is more specific than the class rule. Therefore, secondDiv will be **orange**.

---

## Question 2: Dynamically Target firstDiv and Make its Colour Pink

You can use JavaScript to select the element with the id firstDiv and update its background colour to pink:

```javascript
document.getElementById("firstDiv").style.background = "pink";
```

**Explanation:**  
This line of code selects the element using `document.getElementById("firstDiv")` and then sets its background style property to "pink", thus updating its appearance on the page.

---

## Question 3: Dynamically Target secondDiv and Add the yellow-card Class

You can dynamically add the yellow-card class to the secondDiv element using:

```javascript
document.getElementById("secondDiv").classList.add("yellow-card");
```

**Explanation:**  
Here, `document.getElementById("secondDiv")` retrieves the element. The `classList.add("yellow-card")` method then adds the yellow-card class to the element's list of classes. 

With the added class, the element would now also include the styles defined under `.yellow-card` (setting its background to yellow). However, note that if conflicting background rules exist, the most specific rule or the one declared later in the CSS will prevail. In this scenario, if `#secondDiv { background: orange; }` remains in place, it may continue to override the yellow-card class unless the style order or specificity changes.