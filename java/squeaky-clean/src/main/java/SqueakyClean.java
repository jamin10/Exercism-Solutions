class SqueakyClean {
    static String clean(String identifier) {
        String cleaned = identifier.replace(' ', '_')
            .replaceAll("\\p{Cc}", "CTRL");
            return cleaned;
    }
}
