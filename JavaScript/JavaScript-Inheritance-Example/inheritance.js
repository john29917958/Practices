'use strict';

$(document).ready(function () {
    /**
     * @param {Object} child The child object.
     * @param {Object} parent The parent object.
     * @returns {Object} Returns the child object extended
     * from the parent object.
     */
    function extend(child, parent) {
        if (parent instanceof Object && child instanceof Object) {
            child.prototype = Object.create(Parent.prototype);
            child.prototype.constructor = child;
            
            return child;
        }

        throw "parameters of extend() must be Object.";
    }

    function Parent() {
        
    };

    Parent.prototype.name = "Parent";

    Parent.prototype.hiccups = function () {
        return this.name + ": urrrrgh~";
    };

    Parent.prototype.say = function () {
        return this.name + ": I'm " + this.name + "!";
    };

    function Child() {

    }

    extend(Child, Parent);

    Child.prototype.name = "Child";

    Child.prototype.hiccups = function () {
        return this.name + ": rumble!";
    };

    var child = new Child(),
        parent = new Parent();

    $("#result").append(parent.say() + "<br>").append(child.say() + "<br>").append(parent.hiccups() + "<br>").append(child.hiccups());
});