﻿!function (t, e) { "object" == typeof exports && "object" == typeof module ? module.exports = e(require("angular")) : "function" == typeof define && define.amd ? define(["angular"], e) : "object" == typeof exports ? exports.AngularDragDrop = e(require("angular")) : t.AngularDragDrop = e(t.angular) }(this, function (t) { return function (t) { function e(a) { if (r[a]) return r[a].exports; var n = r[a] = { exports: {}, id: a, loaded: !1 }; return t[a].call(n.exports, n, n.exports, e), n.loaded = !0, n.exports } var r = {}; return e.m = t, e.c = r, e.p = "", e(0) }([function (t, e, r) { function a(t) { var e = t.find("body"); return e.length ? e : t } var n = r(1); t.exports = "filearts.dragDrop"; var o = n.module(t.exports, []), d = '.drag-active .drop-container{position:relative}.drag-active .drop-container *{pointer-events:none}.drag-active .drop-container:before{position:absolute;top:0;right:0;bottom:0;left:0;z-index:9999;content:""}'; o.factory("dragContext", [function () { function t() { return n.extend(r, { data: null, reset: t, start: e }) } function e(t) { return r.data = t, t } var r = {}; return t() }]), o.run(["$document", "$rootElement", "$timeout", function (t, e, r) { function n() { i() } function o() { i() } function i() { r(function () { var t = a(e); t.removeClass("drag-active") }) } function l(t, e) { e || (e = document); var r = e.head || e.getElementsByTagName("head")[0]; if (!r) { r = e.createElement("head"); var a = e.body || e.getElementsByTagName("body")[0]; a ? a.parentNode.insertBefore(r, a) : e.documentElement.appendChild(r) } var n = e.createElement("style"); return n.type = "text/css", n.styleSheet ? n.styleSheet.cssText = t : n.appendChild(e.createTextNode(t)), r.appendChild(n), n } t[0].addEventListener("dragend", n, !0), t[0].addEventListener("drop", o, !0), l(d, t[0]) }]), o.directive("dragContainer", ["$rootElement", "$parse", "$timeout", "dragContext", function (t, e, r, n) { return { restrict: "A", link: function (o, d, i) { function l(e) { if (r(function () { var e = a(t); e.addClass("drag-active") }, 0, !1), n.start(i.dragData ? o.$eval(i.dragData) : d), d.addClass("drag-container-active"), g) { var l = { $event: e, $dragData: n.data }; o.$apply(function () { g(o, l) }) } var s = e.originalEvent || e; s.dataTransfer && (s.dataTransfer.items && s.dataTransfer.items.length || s.dataTransfer.files && s.dataTransfer.files.length || s.dataTransfer.setData("text", "")) } function s(e) { if (r(function () { var e = a(t); e.removeClass("drag-active") }, 0, !1), n.reset(), d.removeClass("drag-container-active"), c) { var i = { $event: e, $dragData: n.data }; o.$apply(function () { c(o, i) }) } n.lastTarget && n.lastTarget.$attrs.$removeClass("drag-over") } var g = i.onDragStart ? e(i.onDragStart) : null, c = i.onDragEnd ? e(i.onDragEnd) : null; i.$addClass("drag-container"), o.$watch(i.dragContainer, function (t) { i.$set("draggable", "undefined" == typeof t || t) }), d.on("dragstart", l), d.on("dragend", s) } } }]), o.directive("dropContainer", ["$document", "$parse", "$window", "dragContext", function (t, e, r, a) { function o(t) { return t[0] || t } function d(e) { e = o(e); var a = e.getBoundingClientRect(); return { width: Math.round(n.isNumber(a.width) ? a.width : e.offsetWidth), height: Math.round(n.isNumber(a.height) ? a.height : e.offsetHeight), top: Math.round(a.top + (r.pageYOffset || t[0].documentElement.scrollTop)), left: Math.round(a.left + (r.pageXOffset || t[0].documentElement.scrollLeft)) } } return { restrict: "A", require: "dropContainer", controller: "DropContainerController", controllerAs: "dropContainer", link: function (t, r, o, i) { function l(e) { a.lastTarget && a.lastTarget !== r && a.lastTarget.$attrs.$removeClass("drag-over"), a.lastTarget = { $attrs: o, $element: r }; var n = { $event: e, $dragData: a.data }; p(t, n) && (e.preventDefault(), o.$addClass("drag-over"), u && t.$apply(function () { u(t, n) })) } function s(e) { var l = { $event: e, $dragData: a.data }; if (p(t, l)) { e.preventDefault(); var s = d(r); o.$addClass("drag-over"); var g = Number.MAX_VALUE, c = s.width, u = s.height, v = e.pageX - s.left, h = e.pageY - s.top, $ = i.lastTarget; n.forEach(i.targets, function (t, e) { var r = c / 2, a = u / 2; e.indexOf("left") >= 0 && (r = 1 * c / 4), e.indexOf("top") >= 0 && (a = 1 * u / 4), e.indexOf("right") >= 0 && (r = 3 * c / 4), e.indexOf("bottom") >= 0 && (a = 3 * u / 4); var n = Math.pow(r - v, 2) + Math.pow(a - h, 2); n < g && ($ = t, g = n) }), t.$apply(function () { f && f(t, l), $ && ($ !== i.lastTarget && (i.lastTarget && o.$removeClass("drop-container-" + i.lastTarget.anchor), o.$addClass("drop-container-" + $.anchor), i.lastTarget && i.lastTarget.handleDragLeave(e, l), $.handleDragEnter(e, l), i.lastTarget = $), $.handleDragOver(e)) }) } } function g(e) { o.$removeClass("drag-over"); var r = { $event: e, $dragData: a.data }; t.$apply(function () { v && v(t, r), i.lastTarget && i.lastTarget.handleDragLeave(e, r), i.lastTarget && (o.$removeClass("drop-container-" + i.lastTarget.anchor), i.lastTarget = null) }) } function c(e) { a.lastTarget && a.lastTarget.$attrs.$removeClass("drag-over"); var r = { $event: e, $dragData: a.data }; p(t, r) && (e.preventDefault(), a.reset(), t.$apply(function () { h && h(t, r), i.lastTarget && i.lastTarget.handleDrop(e, r) })), i.lastTarget && o.$removeClass("drop-container-" + i.lastTarget.anchor), i.lastTarget = null } var p = o.dropAccepts ? e(o.dropAccepts) : function (t, e) { return "undefined" != typeof e.$dragData }, u = o.onDragEnter ? e(o.onDragEnter) : null, f = o.onDragOver ? e(o.onDragOver) : null, v = o.onDragLeave ? e(o.onDragLeave) : null, h = o.onDrop ? e(o.onDrop) : null; o.$addClass("drop-container"), r.on("dragover", s), r.on("dragenter", l), r.on("dragleave", g), r.on("drop", c) } } }]), o.controller("DropContainerController", [function () { var t = this, e = "center top top-right right bottom-right bottom bottom-left left top-left".split(" "); t.targets = {}, t.lastTarget = null, t.attach = function (r) { var a = r.anchor; if (e.indexOf(a) < 0) throw new Error("Invalid drop target anchor `" + a + "`."); return t.targets[a] = r, r }, t.detach = function (r) { var a = r.anchor; if (e.indexOf(a) < 0) throw new Error("Invalid drop target anchor `" + a + "`."); if (!t.targets[a] === r) throw new Error("The indicated drop target is not attached at the anchor `" + a + "`."); return delete t.targets[a], r } }]), o.directive("dropTarget", ["$parse", function (t) { return { restrict: "A", require: ["^dropContainer", "dropTarget"], scope: !0, bindToController: { anchor: "@dropTarget" }, controller: n.noop, controllerAs: "dropTarget", link: function (e, r, a, o) { var d = o[0], i = o[1]; a.$addClass("drop-target"), i.$attrs = a, i.$scope = e, a.$addClass("drop-target drop-target-" + i.anchor), d.attach(i); var l = i.$attrs.onDragEnter ? t(i.$attrs.onDragEnter) : n.noop, s = i.$attrs.onDragLeave ? t(i.$attrs.onDragLeave) : n.noop, g = i.$attrs.onDragOver ? t(i.$attrs.onDragOver) : n.noop, c = i.$attrs.onDrop ? t(i.$attrs.onDrop) : n.noop; i.handleDragEnter = function (t, e) { l(i.$scope, e) }, i.handleDragLeave = function (t, e) { s(i.$scope, e) }, i.handleDragOver = function (t, e) { g(i.$scope, e) }, i.handleDrop = function (t, e) { c(i.$scope, e) }, e.$on("$destroy", function () { d.detach(i) }) } } }]) }, function (e, r) { e.exports = t }]) });