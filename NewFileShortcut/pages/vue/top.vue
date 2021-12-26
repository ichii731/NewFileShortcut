<template>
  <div class="test">
    <div class="markdown-body" v-html="md"></div>
  </div>
</template>
<script>
module.exports = {
  data: function () {
    return {
      title: "NewFileShortCut - 新規ファイルを一発で作成",
      md: null,
    };
  },
  beforeMount: function () {
    fetch("./docs/top.md")
      .then((response) => response.text())
      .then((data) => {
        this.md = markdown.parse(data);
      })
  },
  // Usage with context the component
  head: {
    // To use "this" in the component, it is necessary to return the object through a function
    title: function () {
      return {
        inner: this.title,
      };
    },
    meta: [
      { name: "application-name", content: "NewFileShortCut - 新規ファイルを一発で作成" },
      { name: "description", content: "新規ファイルを指定のショートカットキーで作成できるWindowsソフトウェアです。ファイル内容も設定可能！"}, 
      // ...
      // Twitter
      { name: "twitter:title", content: "NewFileShortCut - 新規ファイルを一発で作成" },
      // with shorthand
      {
        n: "twitter:description",
        c: "新規ファイルを指定のショートカットキーで作成できるWindowsソフトウェアです。ファイル内容も設定可能！",
      },
      { n: "twitter:card", c: "https://ic731.net/NewFileShortcut/bin/ogp.jpg" },
      // ...
      // Facebook / Open Graph
      { property: "og:title", content: "NewFileShortCut - 新規ファイルを一発で作成" },
      // with shorthand
      { p: "og:image", c: "https://ic731.net/NewFileShortcut/bin/ogp.jpg" },
      // ...
    ],
  },
};
</script>