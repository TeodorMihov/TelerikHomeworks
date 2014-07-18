var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var SoftwareAcademy;
(function (SoftwareAcademy) {
    var Course = (function () {
        function Course(initialName, initialTeacher) {
            this.name = initialName;
            this.teacher = initialTeacher;
        }
        return Course;
    })();
    SoftwareAcademy.Course = Course;

    var LocalCourse = (function (_super) {
        __extends(LocalCourse, _super);
        function LocalCourse(initialName, initialTeacher) {
            _super.call(this, initialName, initialTeacher);
        }
        return LocalCourse;
    })(Course);
    SoftwareAcademy.LocalCourse = LocalCourse;

    var OffsiteCourse = (function (_super) {
        __extends(OffsiteCourse, _super);
        function OffsiteCourse(initialName, initialTeacher) {
            _super.call(this, initialName, initialTeacher);
        }
        return OffsiteCourse;
    })(Course);
    SoftwareAcademy.OffsiteCourse = OffsiteCourse;

    var Teacher = (function () {
        function Teacher(name) {
            this.name = name;
            this.courseStorage = new TeacherCourses(10);
        }
        Teacher.prototype.addCourse = function (course) {
            this.courseStorage.addCourse(course);
        };

        Teacher.prototype.removeCourse = function (course) {
            this.courseStorage.removeCourse(course);
        };
        return Teacher;
    })();
    SoftwareAcademy.Teacher = Teacher;

    var TeacherCourses = (function () {
        function TeacherCourses(capacity) {
            this.capacity = capacity || 10;
            this._storage = [];
        }
        TeacherCourses.prototype.addCourse = function (course) {
            if (this.capacity < this._storage.length) {
                throw new Error("Maximum capacity(" + this.capacity + ")");
            } else {
                this._storage.push(course);
            }
        };

        TeacherCourses.prototype.removeCourse = function (course) {
            var courseIndex = this._storage.indexOf(course);
            if (courseIndex > -1) {
                this._storage.splice(courseIndex, 1);
            }
        };

        TeacherCourses.prototype.getCoursesCount = function () {
            return this._storage.length;
        };

        TeacherCourses.prototype.getTeacherCoursesIndex = function (index) {
            if (index > this._storage.length) {
                throw new ReferenceError("Index out of range");
            } else {
                return this._storage[index];
            }
        };
        return TeacherCourses;
    })();
    SoftwareAcademy.TeacherCourses = TeacherCourses;
})(SoftwareAcademy || (SoftwareAcademy = {}));
//# sourceMappingURL=Course.js.map
