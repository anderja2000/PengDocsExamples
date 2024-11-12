# HTML

## What is HTML?

- HTML (HyperText Markup Language) is the standard markup language for creating web pages and web applications.
- It structures content on the web, allowing browsers to interpret and display text, images, and other media.
- HTML elements are the building blocks of web pages, defining the structure and layout of the content.

## HTML Tags and Elements

- HTML tags are the markup used to create elements, typically consisting of an opening tag and a closing tag (e.g., `<p>This is a paragraph.</p>`).
- Common tags include `<p>` for paragraphs, `<h1>` for main headings, and `<a>` for hyperlinks.
- Tags differ from elements; an element includes the tag and its content.

## Attributes and Global Attributes

- Attributes provide additional information about HTML elements, typically in name/value pairs (e.g., `src` in `<img src='image.jpg'>`).
- Global attributes can be applied to any HTML element, such as `class`, `id`, and `style`, enhancing flexibility in styling and scripting.

## Semantic HTML

- Semantic tags (like `<article>`, `<section>`, `<header>`) clearly describe their meaning, improving accessibility and SEO.
- Using semantic HTML helps search engines and assistive technologies understand the content structure better.

## Forms and User Input

- Forms are created using the `<form>` tag, which can contain various input elements like `<input>`, `<textarea>`, and buttons.
- Forms allow users to submit data, which can be processed by web servers.

# CSS

## What is CSS?

- CSS (Cascading Style Sheets) is a stylesheet language used to describe the presentation of a document written in HTML.
- It controls layout, colors, fonts, and overall visual appearance of web pages.

## Selectors and Rules

- Selectors are patterns used to select the elements you want to style (e.g., class selectors `.classname`, ID selectors `#idname`).
- CSS rules consist of selectors and declarations that define how selected elements should be styled.

## Types of Selectors

- Tag selector: `div { ... }` targets all `<div>` elements.
- Class selector: `.classname { ... }` targets all elements with the specified class.
- ID selector: `#idname { ... }` targets a unique element with the specified ID.

## Box Model and Responsive Design

- The CSS box model describes how elements are structured: content, padding, border, and margin.
- Responsive web design ensures that web pages render well on various devices using flexible layouts and media queries.

## Cascading and Specificity

- Cascading refers to how styles apply based on specificity and order of rules; later rules can override earlier ones.
- Specificity determines which CSS rule applies when multiple rules target the same element, with inline styles having the highest priority.