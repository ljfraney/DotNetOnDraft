/// <binding BeforeBuild='default' ProjectOpened='default' /> 
const { src, dest, series, parallel, watch } = require('gulp');
const uglify = require('gulp-uglify');
const flatten = require('gulp-flatten');
const pipeline = require('readable-stream').pipeline;
const cleanCSS = require('gulp-clean-css');
const sass = require('gulp-sass');
const del = require('del');

var fileWatchConfig = [
    'js/**/*.js',
    '!js/**/*.min.js',
    'css/**/*.css',
    'css/**/*.scss'
];

//watch(fileWatchConfig, {}, parallel(compress));

function copy(cb) {
    console.log('Copying bootstrap files...');
    src('node_modules/bootstrap/dist/**/*')
        .pipe(dest('wwwroot/lib/bootstrap/dist/'));

    console.log('Copying jquery files...');
    src('node_modules/jquery/dist/**/*')
        .pipe(dest('wwwroot/lib/jquery/dist/'));

    console.log('Copying popper.js files...');
    src('node_modules/popper.js/dist/**/*')
        .pipe(dest('wwwroot/lib/popper.js/dist/'));

    console.log('Copying jplayer files...');
    src('node_modules/jplayer/dist/**/*')
        .pipe(dest('wwwroot/lib/jplayer/dist/'));

    console.log('Copying vue files...');
    src('node_modules/vue/dist/**/*')
        .pipe(dest('wwwroot/lib/vue/dist/'));

    console.log('Copying moment files...');
    src(['node_modules/moment/**/moment.js', '!node_modules/moment/src/**', 'node_modules/moment/**/moment.*.js'])
        .pipe(flatten())
        .pipe(dest('wwwroot/lib/moment/'));

    cb();
}

function compress(cb) {
    pipeline(
        src('js/site.js'),
        uglify(),
        dest('wwwroot/js')
    );

    src('css/site.css')
        .pipe(cleanCSS({ debug: true }, (details) => {
            console.log(`${details.name} minified from ${details.stats.originalSize} bytes to ${details.stats.minifiedSize} bytes.`);
        }))
        .pipe(dest('wwwroot/css'));

    src('css/jplayer.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(dest('wwwroot/css'));

    cb();
}

function clean(cb) {
    del(['wwwroot/lib/', 'wwwroot/css/site.css', 'wwwroot/css/jplayer.css']);
    cb();
}

exports.clean = parallel(clean);

exports.default = parallel(copy, compress);
