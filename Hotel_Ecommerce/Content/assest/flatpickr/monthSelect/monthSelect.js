!function(t,e){"object"==typeof exports&&"undefined"!=typeof module?module.exports=e():"function"==typeof define&&define.amd?define(e):t.monthSelect=e()}(this,function(){"use strict";function t(){return function(t){function e(e){if(e.target&&e.target.classList.contains("flatpickr-day")){var n=Array.prototype.indexOf.call(o,e.target);t.monthStartDay=new Date(o[n].dateObj.getFullYear(),o[n].dateObj.getMonth(),1,0,0,0,0).getTime(),t.monthEndDay=new Date(o[n].dateObj.getFullYear(),o[n].dateObj.getMonth()+1,0,0,0,0,0).getTime();for(var a=o.length;a--;){var s=o[a].dateObj.getTime();s>t.monthEndDay||s<t.monthStartDay?o[a].classList.remove("inRange"):o[a].classList.add("inRange"),s!=t.monthEndDay?o[a].classList.remove("endRange"):o[a].classList.add("endRange"),s!=t.monthStartDay?o[a].classList.remove("startRange"):o[a].classList.add("startRange")}}}function n(){for(var e=o.length;e--;){var n=o[e].dateObj.getTime();n>=t.monthStartDay&&n<=t.monthEndDay&&o[e].classList.add("month","selected"),n!=t.monthEndDay?o[e].classList.remove("endRange"):o[e].classList.add("endRange"),n!=t.monthStartDay?o[e].classList.remove("startRange"):o[e].classList.add("startRange")}}function a(){for(var t=o.length;t--;)o[t].classList.remove("inRange")}var o;return{onChange:n,onMonthChange:n,onClose:a,onParseConfig:function(){t.config.mode="single",t.config.enableTime=!1},onReady:[function(){o=t.days.childNodes},function(){return t.days.addEventListener("mouseover",e)},n]}}}return t});
//# sourceMappingURL=monthSelect.js.map