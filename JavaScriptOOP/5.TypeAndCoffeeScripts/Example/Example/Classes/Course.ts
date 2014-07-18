module SoftwareAcademy {
    export class Course implements ICourse {
        name: string;
        teacher: Teacher;

        constructor(initialName: string, initialTeacher: Teacher) {
            this.name = initialName;
            this.teacher = initialTeacher
        }
    }

    export class LocalCourse extends Course {
        constructor(initialName: string, initialTeacher: Teacher) {
            super(initialName, initialTeacher)
        }
    }

    export class OffsiteCourse extends Course {
        constructor(initialName: string, initialTeacher: Teacher) {
            super(initialName, initialTeacher)
        }
    }

    export class Teacher implements ITeacher {
        name: string;
        courseStorage: TeacherCourses<Course>;

        constructor(name: string) {
            this.name = name;
            this.courseStorage = new TeacherCourses<Course>(10);
        }

        addCourse(course: Course) {
            this.courseStorage.addCourse(course);
        }

        removeCourse(course: Course) {
            this.courseStorage.removeCourse(course);
        }
    }

    export class TeacherCourses<T> {
        capacity: number;
        private _storage: T[];

        constructor(capacity?: number) {
            this.capacity = capacity || 10;
            this._storage = [];
        }

        addCourse(course: T) {
            if (this.capacity < this._storage.length) {
                throw new Error("Maximum capacity(" + this.capacity + ")");
            } else {
                this._storage.push(course);
            }
        }

        removeCourse(course: T) {
            var courseIndex = this._storage.indexOf(course);
            if (courseIndex > -1) {
                this._storage.splice(courseIndex, 1);
            }
        }

        getCoursesCount() {
            return this._storage.length;
        }

        getTeacherCoursesIndex(index: number): T {
            if (index > this._storage.length) {
                throw new ReferenceError("Index out of range");
            } else {
                return this._storage[index];
            }
        }
    }
}