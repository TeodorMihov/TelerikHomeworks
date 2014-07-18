var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Animal = (function (_super) {
    __extends(Animal, _super);
    function Animal(name) {
        _super.call(this, name);
    }
    Animal.prototype.move = function () {
    };

    Animal.prototype.makeSound = function () {
    };
    return Animal;
})(Creature);
//# sourceMappingURL=Animal.js.map
