/* */ 
var $def = require("./$.def"),
    sign = require("./$.sign");
$def($def.S, 'Math', {cbrt: function cbrt(x) {
    return sign(x = +x) * Math.pow(Math.abs(x), 1 / 3);
  }});
