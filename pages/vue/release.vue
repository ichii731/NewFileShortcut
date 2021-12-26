<template>
  <div class="test">
    <div class="markdown-body" v-html="md"></div>
  </div>
</template>
<script>
module.exports = {
  data: function () {
    return {
      title: "リリースノート",
      md: null,
    };
  },
  beforeMount: function () {
    fetch("README.md")
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
  },
};
</script>