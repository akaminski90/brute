var gulp = require('gulp'), // ���������� Gulp
    sass = require('gulp-sass'); // ���������� Sass �����

gulp.task('sass', function() { // ������� ���� "sass"
  return gulp.src(['sass/**/*.sass', 'sass/**/*.scss']) // ����� ��������
    .pipe(sass({outputStyle: 'expanded'}).on('error', sass.logError)) // ����������� Sass � CSS ����������� gulp-sass
    .pipe(gulp.dest('css')) // ��������� ���������� � ����� css
  });

gulp.task('autoprefixer', ['sass'], function () {
  var postcss      = require('gulp-postcss');
  var sourcemaps   = require('gulp-sourcemaps');
  var autoprefixer = require('autoprefixer');

  return gulp.src('./css/*.css')
      .pipe(sourcemaps.init())
      .pipe(postcss([ autoprefixer({ browsers: ['last 10 versions'] }) ]))
      .pipe(sourcemaps.write('.'))
      .pipe(gulp.dest('./css'));
});

gulp.task('watch', function() {
  gulp.watch(['sass/**/*.sass', 'sass/**/*.scss'], ['autoprefixer']); // ���������� �� sass ������� � ����� sass
});

gulp.task('default', ['watch']);