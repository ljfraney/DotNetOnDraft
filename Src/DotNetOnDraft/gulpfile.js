/// <binding BeforeBuild='default' ProjectOpened='default' />
const { src, dest, parallel } = require('gulp');
const uglify = require('gulp-uglify');
const pipeline = require('readable-stream').pipeline;
const cleanCSS = require('gulp-clean-css');
const sass = require('gulp-sass');

function copy(cb) {
    console.log('Copying bootstrap files...');
    src('node_modules/bootstrap/dist/**/*')
        .pipe(dest('wwwroot/lib/bootstrap/dist'));

    console.log('Copying jquery files...');
    src('node_modules/jquery/dist/**/*')
        .pipe(dest('wwwroot/lib/jquery/dist'));

    console.log('Copying popper.js files...');
    src('node_modules/popper.js/dist/**/*')
        .pipe(dest('wwwroot/lib/popper.js/dist'));

    console.log('Copying jplayer files...');
    src('node_modules/jplayer/dist/**/*')
        .pipe(dest('wwwroot/lib/jplayer/dist'));

    cb();
}

function compress(cb) {
    pipeline(
        src('site.js'),
        uglify(),
        dest('wwwroot/js')
    );

    src('site.css')
        .pipe(cleanCSS({ debug: true }, (details) => {
            console.log(`${details.name} minified from ${details.stats.originalSize} bytes to ${details.stats.minifiedSize} bytes.`);
        }))
        .pipe(dest('wwwroot/css'));

    src('jplayer.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(dest('wwwroot/css'));

    cb();
}

exports.default = parallel(copy, compress);
