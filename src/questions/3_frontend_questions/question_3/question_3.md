# Question 3: Answers

## Question 1: How would you make a web page mobile friendly (i.e responsive)?

To ensure your website adjusts properly to various screen sizes, you can implement these responsive design techniques:

### Add a viewport meta tag in your HTML header

This tells mobile browsers how to scale your page:

```html
<meta name="viewport" content="width=device-width, initial-scale=1.0">
```

This essential line ensures that the page width matches the device width, which is fundamental for responsiveness.

### Use CSS media queries

Media queries allow you to apply different styles based on the screen size:

```css
/* Base styling for larger screens */
body {
    font-size: 16px;
    margin: 0;
    padding: 0;
}

/* Adjust styles for devices with a width of 768px or less */
@media (max-width: 768px) {
    body {
        font-size: 14px;
        padding: 10px;
    }
    .container {
        width: 100%;
        margin: 0;
    }
}
```

This approach lets you create specific styles for mobile devices without affecting the layout on larger screens.

### Implement flexible layouts and images

Instead of fixed widths, use relative units (percentages) so elements can scale:

```css
.container {
    width: 80%;
    margin: auto;
}
img {
    max-width: 100%;
    height: auto;
}
```

These practices ensure that images and containers adjust seamlessly across different devices.

### Consider responsive frameworks

You could also use frameworks like Bootstrap or Foundation that are built with responsiveness in mind. They provide predefined classes and grid systems to simplify responsive design implementation.

## Question 2: What is the benefit of bundling .js scripts into one file?

Bundling your JavaScript files into one file offers several advantages:

### Reduced HTTP requests

When you bundle your scripts, the browser only needs to load a single file rather than multiple files. Fewer requests mean faster load times and reduced latency, particularly important on mobile or slow networks.

### Improved performance

A single, bundled file can be minified and optimized, reducing overall file size. This helps your website load and execute scripts faster.

### More efficient caching

The browser can cache the single bundled file. On subsequent visits, the browser can quickly load it from cache rather than re-downloading multiple separate files.

### Simplified code management

Bundling (via tools like Webpack, Rollup, or Parcel) also helps manage code dependencies, making it easier to develop and maintain complex projects.

## Question 3: What needs to be done to ensure the browser understands Sass styling?

Browsers do not understand Sass directly; they only understand standard CSS. Therefore, you need to:

### Compile Sass to CSS

Use a Sass compiler (such as Dart Sass or node-sass) to convert your .scss or .sass files into plain CSS. This process is usually integrated into your build process.

For example, using the Sass CLI:

```bash
sass input.scss output.css
```

This command takes your Sass file (input.scss) and compiles it into a CSS file (output.css).

### Integrate with build tools

Alternatively, you can integrate Sass compilation into your build process with tools like Gulp, Grunt, or Webpack (using the sass-loader) to automate this task.

## Question 4: What should be done to ensure browser compatibility with newer flavours of JavaScript like ES6/7?

Newer flavours of JavaScript (ES6/ES7) include many modern features that older browsers might not support. To ensure compatibility, consider the following approaches:

### Transpile your code using Babel

Babel is a popular tool that converts ES6/7 code into ES5 code, which is more widely supported by all browsers. This allows you to write modern JavaScript without worrying about backwards compatibility.

For example, you can set up a Babel configuration file (.babelrc) to specify presets:

```json
{
  "presets": ["@babel/preset-env"]
}
```

### Use polyfills

Some ES6/7 features, such as Promises or certain array methods, may not work in older browsers even after transpiling. Polyfills (like core-js) can be included in your project to provide these missing features.

### Testing and linting

Regularly test your code in different browsers and consider using tools like ESLint to catch potential compatibility issues early in the development process.