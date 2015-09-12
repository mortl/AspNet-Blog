/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    concat = require('gulp-concat'),
    uglifycss = require('gulp-uglifycss'),
    del=require('del');
        
  
gulp.task('copyJavaScript', function () {
    gulp.src([
        'wwwroot/lib/jquery/dist/jquery.min.js',
        'wwwroot/lib/bootstrap/dist/js/bootstrap.min.js'
    ])
    .pipe(concat('third-party.js'))
    .pipe(gulp.dest('wwwroot/lib'))
});


gulp.task('copyCss', function () {
    gulp.src([
        'bower_components/bootstrap/dist/css/bootstrap.min.css',
        'wwwroot/blog.css'
    ])
    .pipe(uglifycss())
    .pipe(concat('site.css'))
    .pipe(gulp.dest('wwwroot/lib'))
});

