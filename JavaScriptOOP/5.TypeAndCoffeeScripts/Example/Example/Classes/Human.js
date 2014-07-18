var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Human = (function (_super) {
    __extends(Human, _super);
    function Human(name, type) {
        _super.call(this, name);
        this.type = type;
        this._numberOfLegs = 4;
        this._numberOfEyes = 2;
        this._health = 100;
    }
    Object.defineProperty(Human.prototype, "health", {
        get: function () {
            return this._health;
        },
        enumerable: true,
        configurable: true
    });
    return Human;
})(Animal);
//# sourceMappingURL=Human.js.map
