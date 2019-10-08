/* Error: @content is only allowed within mixin declarations.
 *   ,
 * 7 |         @content       
 *   |         ^^^^^^^^^^^^^^^
 *   '
 *   assets\styles\mixins.sass 7:9  @import
 *   assets\styles\style.sass 1:9   root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: @content is only allowed within mixin declarations.\a   \2577 \a 7 \2502          @content       \a   \2502          ^^^^^^^^^^^^^^^\a   \2575 \a   assets\\styles\\mixins.sass 7:9  @import\a   assets\\styles\\style.sass 1:9   root stylesheet";
}
