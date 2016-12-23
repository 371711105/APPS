/*!
 * node -v
 * npm -v
 * npm install gulp -g //全局安装gulp
 * gulp -v
 * npm init //新增package.json
 * npm install gulp --save-dev //本地安装gulp插件
 * npm init //创建package.json 也可以手动添加
 * gulp
 * $ npm install gulp-ruby-sass gulp-minify-css gulp-autoprefixer gulp-imagemin gulp-clean-css gulp-jshint gulp-concat gulp-uglify gulp-imagemin gulp-notify gulp-rename gulp-livereload gulp-cache gulp-clean del gulp-htmlmin --save-dev
 */

//load plugins
var gulp = require("gulp"),
	sass = require("gulp-ruby-sass"), //sass的编译
    autoprefixer = require("gulp-autoprefixer"), //自动添加css前缀
    minifycss = require("gulp-minify-css"), //压缩css
    uglify = require("gulp-uglify"), //压缩js代码
    imagemin = require("gulp-imagemin"), //压缩图片
    rename = require("gulp-rename"),//重命名
    concat = require("gulp-concat"), //合并js文件
    notify = require("gulp-notify"),//更改提醒
    cache = require("gulp-cache"),//图片缓存，只有图片替换了才压缩
    livereload = require("gulp-livereload"),
    htmlmin = require("gulp-htmlmin"),//Html压缩
    clean = require("gulp-clean"),
    ejs = require("gulp-ejs"),//ejs
    plumber = require("gulp-plumber"),//错误处理插件
    watch = require("gulp-watch"); //监听

//ejs
gulp.task('ejs', () => {
    return gulp.src(["views-ejs/*.ejs", "views-ejs/**/*.ejs"])
		.pipe(plumber())
		.pipe(ejs({ text: 1 }, { ext: '.html' }))
		.pipe(gulp.dest("views/"))
});
// styles
gulp.task("styles", function () {
    return gulp.src(["css/*.css", "css/**/*.css"])
		.pipe(minifycss())
		.pipe(gulp.dest("build/css"));
});

//scripts
gulp.task("scripts", function () {
    return gulp.src(["js/*.js", "js/**/*.js"])
		.pipe(uglify())
		.pipe(gulp.dest("build/js"));
});

//views
gulp.task("views", function () {
    return gulp.src(["views/*.html", "views/**/*.html"])
		.pipe(gulp.dest("build/views"));
});

//images
gulp.task("images", function () {
    return gulp.src(["*.ico", "images/*", "images/**/*"])
		.pipe(cache(imagemin({
		    optimizationLevel: 5, //类型：Number  默认：3  取值范围：0-7（优化等级）
		    progressive: true, //类型：Boolean 默认：false 无损压缩jpg图片
		    interlaced: true, //类型：Boolean 默认：false 隔行扫描gif进行渲染
		    multipass: true //类型：Boolean 默认：false 多次优化svg直到完全优化
		})))
		.pipe(gulp.dest("build/images"));
});

//cleanAll
gulp.task("clean", function () {
    return gulp.src(["build/css", "build/js", "build/images", "build/views"])
		.pipe(clean());
});

//clean styles
gulp.task("cleanStyles", function () {
    return gulp.src("build/css")
	    .pipe(clean());
});

//clean scripts
gulp.task("cleanScripts", function () {
    return gulp.src("build/js")
	    .pipe(clean());
});

//clean images
gulp.task("cleanImages", function () {
    return gulp.src("build/images")
	    .pipe(clean());
});

//clean view
gulp.task("cleanViews", function () {
    return gulp.src(["build/views"])
	    .pipe(clean());
});

//default
gulp.task("default", ["clean"], function () {
    gulp.start("styles", "scripts", "images", "views");
});

// Watch
gulp.task("watch", function () {
    gulp.watch(["css/*.css", "css/**/*.css"], ["styles"]);
    gulp.watch(["js/*.js", "js/**/*.js"], ["scripts"]);
    gulp.watch(["images/*", "images/**/*"], ["images"]);
    gulp.watch(["views/*.html", "views/**/*.html"], ["views"]);
    // Create LiveReload server
    livereload.listen();
    // Watch any files in build/, reload on change
    gulp.watch(["build/**"]).on("change", livereload.changed);
});